using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : BombDecorator
{
    public Ice(float damage) : base(damage)
    {
    }

    public override IBomb Decorate(IBomb bomb)
    {
        Debug.Log("Add Ice Damage.");
        bomb.DamageTypes |= DamageType.Ice;
        bomb.Damage += Damage;
        return bomb;
    }
}
