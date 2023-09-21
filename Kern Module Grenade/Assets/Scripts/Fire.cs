using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : BombDecorator
{
    public Fire(float damage) : base(damage)
    {
    }

    public override void Decorate(IBomb bomb, ref Action triggerEvent)
    {
        if (!bomb.DamageTypes.Contains(damageType))
        {
            bomb.DamageTypes.Add(damageType);
        }

        triggerEvent += ActivateEffect;
        bomb.Damage += Damage;
    }

    protected override void ActivateEffect()
    {
        Debug.Log($"{damageType} effect activated.");
    }
}
