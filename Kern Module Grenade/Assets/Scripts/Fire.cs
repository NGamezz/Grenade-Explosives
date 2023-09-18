using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : BombDecorator
{
    public Fire(float damage) : base(damage)
    {
    }

    public override IBomb Decorate(IBomb bomb)
    {
        Debug.Log("Add Fire Damage.");
        bomb.DamageTypes |= DamageType.Fire;
        bomb.Damage += Damage;
        return bomb;
    }
}
