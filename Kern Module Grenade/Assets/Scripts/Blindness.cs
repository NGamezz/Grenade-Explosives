using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blindness : BombDecorator
{
    public Blindness(float damage) : base(damage)
    {
    }

    public override void Decorate(IBomb bomb, ref Action triggerEvent)
    {
        if (!bomb.DamageTypes.Contains(DamageType.Blindness))
        {
            bomb.DamageTypes.Add(DamageType.Blindness);
        }

        triggerEvent += ActivateEffect;
        bomb.Damage += Damage;
    }

    protected override void ActivateEffect()
    {
        Debug.Log($"{damageType} effect activated.");
    }
}
