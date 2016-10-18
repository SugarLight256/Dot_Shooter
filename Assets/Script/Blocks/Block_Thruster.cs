using UnityEngine;
using System.Collections;
using System;

public class Block_Thruster : BlockBase
{

    private float speed;
    private Rigidbody2D myRigid;

    private KeyCode key;

    public Block_Thruster(int rot) : base(rot)
    {
    }

    protected override void Init()
    {
        HP = 50;
        speed = 10;
        switch (rotate)
        {
            case (int)BlockRotate.DOWN:
                key = KeyCode.S;
                break;
            case (int)BlockRotate.LEFT:
                key = KeyCode.D;
                break;
            case (int)BlockRotate.RIGHT:
                key = KeyCode.A;
                break;
            case (int)BlockRotate.UP:
                key = KeyCode.W;
                break;
        }
        connect[(rotate + (int)BlockRotate.DOWN)%4] = false;
        connect[(rotate + (int)BlockRotate.UP) % 4] = true;
        connect[(rotate + (int)BlockRotate.RIGHT) % 4] = false;
        connect[(rotate + (int)BlockRotate.LEFT) % 4] = false;
        myRigid = GetComponent<Rigidbody2D>();
    }

    protected override void Update2()
    {
        if (Input.GetKey(key))
        {
            myRigid.velocity = transform.up * speed;
        }
    }

}
