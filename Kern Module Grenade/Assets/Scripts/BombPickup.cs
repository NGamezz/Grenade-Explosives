using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BombDecorator))]
public class BombPickup : MonoBehaviour
{
    [SerializeField] private BombElementsData bombElemensDataObject;
    private BombDecorator[] bombDecorators => GetComponents<BombDecorator>();

    public void OnPickup()
    {
        foreach (BombDecorator decorator in bombDecorators)
        {
            if (!bombElemensDataObject.damageTypes.Contains(decorator.damageType))
            {
                bombElemensDataObject.damageTypes.Add(decorator.damageType);
                bombElemensDataObject.bombDecorators.Add(decorator);
            }
        }

        Destroy(gameObject);
    }
}