using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnBomb : MonoBehaviour
{
    [SerializeField] private GameObject baseBombPrefab;
    [SerializeField] private BombElementsData bombElementsData;

    public void SpawnBombFunction()
    {
        GameObject spawnedBomb = Instantiate(baseBombPrefab, transform.position, Quaternion.identity);
        foreach (BombDecorator decorator in bombElementsData.bombDecorators)
        {
            BombDecorator bombDecorator = (BombDecorator)spawnedBomb.AddComponent(decorator.GetType());
            bombDecorator.damageType = decorator.damageType;
            bombDecorator.Damage = decorator.Damage;
        }

        spawnedBomb.GetComponent<Timer>().StartTimer();
    }

    private void OnDisable()
    {
        bombElementsData.bombDecorators.Clear();
        bombElementsData.damageTypes.Clear();
    }
}
