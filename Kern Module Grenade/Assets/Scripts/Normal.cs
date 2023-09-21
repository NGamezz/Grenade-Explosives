using UnityEngine;
using System;

public class Normal : BombDecorator
{
    public Normal(float damage) : base(damage)
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
