using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : BombDecorator
{
    public Fire(float damage) : base(damage)
    {
    }

    public override void Decorate(IBomb bomb)
    {
        Debug.Log("Add Fire Damage.");

        if (!bomb.DamageTypes.Contains(DamageType.Fire))
        {
            bomb.DamageTypes.Add(DamageType.Fire);
        }

        bomb.Damage += Damage;
    }
}
