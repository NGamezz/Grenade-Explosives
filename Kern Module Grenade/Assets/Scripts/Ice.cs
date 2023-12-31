using System;
using UnityEngine;

public class Ice : BombDecorator
{
    public Ice(float damage) : base(damage)
    {
    }

    public override void Decorate(IBomb bomb, ref Action triggerEvent)
    {
        if (!bomb.DamageTypes.Contains(DamageType.Ice))
        {
            bomb.DamageTypes.Add(DamageType.Ice);
        }

        triggerEvent += ActivateEffect;
        bomb.Damage += Damage;
    }

    protected override void ActivateEffect()
    {
        Debug.Log($"{damageType} effect activated.");
    }
}
