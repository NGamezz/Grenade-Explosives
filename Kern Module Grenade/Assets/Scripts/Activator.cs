using System;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField] BombElementsData bombsElementsData;

    public void OnStart()
    {
        BombDecorator[] decorators = GetComponents<BombDecorator>();
        Bomb bomb = new(5.0f);

        foreach (BombDecorator decorator in decorators)
        {
            decorator.Decorate(bomb, ref bomb.TriggerEvent);
        }

        bomb.Explode();
        Destroy(gameObject);
    }
}
