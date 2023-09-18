
using UnityEngine;

public interface IBomb
{
    public float Damage { get; set; }
    public DamageType DamageTypes { get; set; }
    public void Explode();
}

public enum DamageType
{
    Normal = 0,
    Fire = 1,
    Ice = 2,
}

public class Bomb : MonoBehaviour, IBomb
{
    public float Damage { get; set; }
    public DamageType DamageTypes { get; set; } = DamageType.Normal;

    public Bomb(float damage)
    {
        Damage = damage;
    }

    public void Explode()
    {
        Debug.Log($"Deal {Damage} {DamageTypes} Damage");
    }
}