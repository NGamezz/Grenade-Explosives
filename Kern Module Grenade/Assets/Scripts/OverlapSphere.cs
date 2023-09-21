using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OverlapSphere : MonoBehaviour
{
    public List<IDamagable> OnStart(Vector3 position, float radius, LayerMask layerMask)
    {
        List<IDamagable> damagables = new();

        Collider[] collliders = Physics.OverlapSphere(position, radius, layerMask);
        foreach (Collider collider in collliders)
        {
            collider.TryGetComponent(out IDamagable damagable);
            damagables.Add(damagable);
        }

        return damagables;
    }
}
