using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : BombDecorator
{
    public Ice(float damage) : base(damage)
    {
    }

    public override void Decorate(IBomb bomb)
    {
        Debug.Log("Add Ice Damage.");

        if (!bomb.DamageTypes.Contains(DamageType.Ice))
        {
            bomb.DamageTypes.Add(DamageType.Ice);
        }

        bomb.Damage += Damage;
    }
}
