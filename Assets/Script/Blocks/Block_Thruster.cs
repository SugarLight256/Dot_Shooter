using UnityEngine;
using System.Collections;
using System;

public class Block_Thruster : BlockBase
{

    private float speed;
    private Rigidbody2D myRigid;

    private KeyCode key;

    protected override void Init()
    {
        HP = 50;
        speed = 1;
        myRigid = GetComponent<Rigidbody2D>();
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
        connect[(int)BlockRotate.DOWN] = false;
        connect[(int)BlockRotate.UP] = false;
        connect[(int)BlockRotate.RIGHT] = false;
        connect[(int)BlockRotate.LEFT] = true;
    }

    protected override void Update2()
    {
        if (Input.GetKey(key))
        {
            myRigid.velocity = transform.up * speed;
        }
        else
        {
            myRigid.velocity = Vector3.zero;
            myRigid.angularVelocity = 0;
        }
    }

}
