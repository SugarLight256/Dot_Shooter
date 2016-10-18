using UnityEngine;
using System.Collections;

public class Block_Common : BlockBase {

    public Block_Common(int rot): base(rot)
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
