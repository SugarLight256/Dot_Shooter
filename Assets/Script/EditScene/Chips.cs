using UnityEngine;
using System.Collections;

public class Chips : MonoBehaviour {

    [SerializeField]
    private BlockMapManager MapManager;
    [SerializeField]
    private PartsPanel panel;
    [SerializeField]
    private BlockID knd;
    private int rotate = 0;

	// Use this for initialization
	void Start () {
        MapManager = GameObject.Find("BlockMap_Manager").GetComponent<BlockMapManager>();
        panel = GameObject.Find("PartsPanel").GetComponent<PartsPanel>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RotateOnce();
        }
	}

    private void gridMove()
    {
        transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), 0);
    }

    private bool isOnGrid()
    {
        if (transform.position.x < 7.5 && transform.position.x > -7.5 && transform.position.y < 7.5 && transform.position.y > -7.5)
        {
            return true;
        }
        return false;
    }

    public void RotateOnce()
    {
        rotate = ++rotate % 4;
        transform.Rotate(new Vector3(0,0,90));
    }

    public void RotateN(int n)
    {
        rotate += n;
        rotate %= 4;
        transform.rotation = Quaternion.Euler(new Vector3(0,0,90 * n));
    }

    void OnMouseDrag()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPos.x, newPos.y, 0);
        if(isOnGrid())
        {
            gridMove();
        }
    }

    void OnMouseUp()
    {
        panel.rePlaceChip(knd, rotate);
        if (isOnGrid())
        {
            MapManager.setBlock((int)Mathf.Round(transform.position.x), (int)Mathf.Round(transform.position.y), knd, rotate);
        }
        Destroy(transform.gameObject);
    }

}
