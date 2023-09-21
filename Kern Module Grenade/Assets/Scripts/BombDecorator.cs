using System;
using UnityEngine;

public interface IBombDecorator
{
}

public abstract class BombDecorator : MonoBehaviour, IBombDecorator
{
    [SerializeField] private float damage = 5.0f;
    public DamageType damageType;

    public float Damage
    {
        get
        {

            return damage;
        }
        set
        {
            if (damage != value)
            {
                damage = value;
            }
        }
    }

    public BombDecorator(float damage)
    {
        Damage = damage;
    }

    public abstract void Decorate(IBomb bomb, ref Action triggerEvent);

    protected abstract void ActivateEffect();
}
