using UnityEngine;
using System.Collections;
using DG.Tweening;

public class PartsPanel : MonoBehaviour {

    [SerializeField]
    private float overPos;
    [SerializeField]
    private float firstPos;

    [SerializeField]
    private GameObject[] chipList = new GameObject[ConstData.ALL_BLOCK_COUNT];
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x - 17.5 / 2f
            && transform.position.x == overPos)
        {
            transform.DOMove(new Vector3(firstPos, 0, 0), 0.5f);
        }

	}

    void OnMouseEnter()
    {
        transform.DOMove(new Vector3(overPos, 0, 0), 0.5f);
    }

    public void rePlaceChip(BlockID knd)
    {
        GameObject tmp;
        tmp = (GameObject)Instantiate(chipList[(int)knd]);
        tmp.transform.SetParent(transform);
        tmp.transform.localPosition = new Vector3(-7, 7 - (int)knd + 1, -1);
    }
}
