using UnityEngine;
using System.Collections;

public class BlockMapManager : MonoBehaviour {

    public static MapElement[,] BlockMap = new MapElement[ConstData.MAP_SIZE, ConstData.MAP_SIZE];

    [SerializeField]
    private GameObject[] BlockList = new GameObject[ConstData.ALL_BLOCK_COUNT];
    private GameObject Player;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
        for(int i=0; i<BlockMap.GetLength(0); i++)
        {
            for (int j = 0; j < BlockMap.GetLength(1); j++)
            {
                BlockMap[i, j] = new MapElement();
            }
        }
    }
	
	public void setBlock(int x, int y, BlockID knd, int rotate)
    {
        GameObject tmpObj;
        BlockMap[ConstData.MAP_SIZE/2 + x, ConstData.MAP_SIZE/2 + y].knd = knd;
        BlockMap[ConstData.MAP_SIZE/2 + x, ConstData.MAP_SIZE/2 + y].rotate = rotate;
        tmpObj = (GameObject)Instantiate(BlockList[(int)knd], new Vector2(x, y), transform.rotation);
        tmpObj.transform.SetParent(Player.transform);
        tmpObj.GetComponent<FixedJoint2D>().connectedBody = Player.GetComponent<Rigidbody2D>();
    }

    public void setColor(int x, int y, Color color)
    {
        BlockMap[x, y].setColor(color);
    }

    private void reloadMap()
    {

    }
}
