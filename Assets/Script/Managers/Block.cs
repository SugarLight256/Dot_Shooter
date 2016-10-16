using UnityEngine;
using System.Collections;

public enum BlockID{
    None,
    Core,
    Common,
    Thruster,
    Shield,

}

public class Block{

    private BlockID knd;

    Block()
    {
        knd = BlockID.None;
    }


    public void setKnd(BlockID knd)
    {
        this.knd = knd;
    }

    public void setColor(Color color)
    {
        if(knd == BlockID.Common)
        {

        }
    }

}
