using UnityEngine;
using System.Collections.Generic;
using System;

public interface IBomb
{
    public float Damage { get; set; }
    public List<DamageType> DamageTypes { get; set; }
    public void Explode();
}

public class Bomb : IBomb
{
    public float Damage { get; set; }

    public Action TriggerEvent = null;

    public List<DamageType> DamageTypes { get; set; } = new List<DamageType>();

    public Bomb(float damage)
    {
        DamageTypes.Add(DamageType.Normal);
        Damage = damage;
    }

    public void Explode()
    {
        Debug.Log($"Deal {Damage} Damage [{string.Join(",", DamageTypes)}]");
        TriggerEvent?.Invoke();
        TriggerEvent = null;
    }
}