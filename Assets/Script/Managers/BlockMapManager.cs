using UnityEngine;
using System.Collections;

public class BlockMapManager : MonoBehaviour {

    public static Block[,] BlockMap = new Block[15,15];

	// Use this for initialization
	void Start () {
	
	}
	
	public void setBlock(int x, int y, BlockID knd)
    {
        BlockMap[x, y].setKnd(knd);
    }

    public void setColor(int x, int y, Color color)
    {
        BlockMap[x, y].setColor(color);
    }
}
