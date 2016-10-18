using UnityEngine;
using System.Collections;

public class Block_Shield : BlockBase {

    private int shieldPower;
    private int shieldPowerMax;

    private float shieldCool;

    public Block_Shield(int rot) : base(rot)
    {

    }

    protected override void Init()
    {
        HP = 100;
        shieldPowerMax = 10;
        shieldCool = 10;
        shieldPower = shieldPowerMax;
        connect[(int)BlockRotate.DOWN - rotate] = true;
        connect[(int)BlockRotate.UP - rotate] = false;
        connect[(int)BlockRotate.RIGHT - rotate] = false;
        connect[(int)BlockRotate.LEFT - rotate] = false;
        StartCoroutine(shieldHealing());
    }

    public override void Damaging(int damage)
    {
        shieldPower -= damage;
        if (shieldPower <= 0)
        {
            base.Damaging(damage);
        }
        StopCoroutine(shieldHealing());
        StartCoroutine(shieldHealing());
    }

    private IEnumerator shieldHealing()
    {
        yield return new WaitForSeconds(shieldCool);
        shieldPower = shieldPowerMax;
    }

}
