using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : BombDecorator
{
    public Poison(float damage) : base(damage)
    {
    }

    public override void Decorate(IBomb bomb, ref Action triggerEvent)
    {
        if (!bomb.DamageTypes.Contains(DamageType.Poison))
        {
            bomb.DamageTypes.Add(DamageType.Poison);
        }

        triggerEvent += ActivateEffect;
        bomb.Damage += Damage;
    }

    protected override void ActivateEffect()
    {
        Debug.Log($"{damageType} effect activated.");
    }
}
