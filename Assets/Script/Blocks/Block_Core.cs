using UnityEngine;
using System.Collections;
using System;

public class Block_Core : BlockBase
{

    public Block_Core(int rot) : base(rot)
    {

    }

    protected override void Init()
    {
        HP = 100;
        connect[(int)BlockRotate.DOWN - rotate] = true;
        connect[(int)BlockRotate.UP - rotate] = true;
        connect[(int)BlockRotate.RIGHT - rotate] = true;
        connect[(int)BlockRotate.LEFT - rotate] = true;
    }
}
