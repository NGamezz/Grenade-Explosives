using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BombDecorator
{
    public float Damage { get; set; }

    public BombDecorator(float damage)
    {
        Damage = damage;
    }

    public abstract void Decorate(IBomb bomb);
}
