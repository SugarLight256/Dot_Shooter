using UnityEngine;
using System.Collections;

enum BlockRotate
{
    UP,
    RIGHT,
    DOWN,
    LEFT
}

public abstract class BlockBase : MonoBehaviour {
    
    protected int HP { get; set; }
    protected bool[] connect = new bool[4];

    protected int rotate=0;

    // Use this for initialization
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        Update2();
    }

    protected virtual void Update2()
    {

    }

    protected abstract void Init();

    protected virtual void Killd()
    {
        Destroy(transform.gameObject);
    }

    public virtual void Damaging(int damage)
    {
        HP -= damage;
        if(HP <= 0)
        {
            Killd();
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Damaging(1);
    }
}
