using UnityEngine;
using System.Collections.Generic;
using System;

public interface IBomb
{
    public float Damage { get; set; }
    public List<DamageType> DamageTypes { get; set; }
    public void Explode();
}

public enum DamageType
{
    Normal = 0,
    Fire = 1,
    Ice = 2,
}

public class Bomb : IBomb
{
    public float Damage { get; set; }
    public List<DamageType> DamageTypes { get; set; } = new List<DamageType>();

    public Bomb(float damage)
    {
        DamageTypes.Add(DamageType.Normal);
        Damage = damage;
    }

    public void Explode()
    {
        Debug.Log($"Deal {Damage} Damage [{string.Join(",", DamageTypes)}]");
    }
}