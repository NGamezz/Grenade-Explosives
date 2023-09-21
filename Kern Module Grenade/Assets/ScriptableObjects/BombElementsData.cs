using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageTypeData", menuName = "ScriptableObjects/DamageTypeData", order = 1)]
public class BombElementsData : ScriptableObject
{
    [NonSerialized] public List<BombDecorator> bombDecorators = new();

    [NonSerialized] public List<DamageType> damageTypes = new();
}
