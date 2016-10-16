using UnityEngine;
using System.Collections;
using System;

public class Block_Core : BlockBase
{
    protected override void Init()
    {
        HP = 100;
        connect[(int)BlockRotate.DOWN] = true;
        connect[(int)BlockRotate.UP] = true;
        connect[(int)BlockRotate.RIGHT] = true;
        connect[(int)BlockRotate.LEFT] = true;
    }
}
