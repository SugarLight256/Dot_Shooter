using UnityEngine;
using System.Collections;

public enum BlockID{
    None,
    Common,
    Core,
    Shield,
    Thruster,
    Weapon
}

public class MapElement { 

    public BlockID knd;
    public int rotate;

    public MapElement()
    {
        knd = BlockID.None;
    }

    public void setColor(Color color)
    {
        if(knd == BlockID.Common)
        {

        }
    }

}
