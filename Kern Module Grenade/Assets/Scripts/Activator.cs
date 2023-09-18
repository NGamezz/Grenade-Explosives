using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Activator : MonoBehaviour
{

    [SerializeField] private UnityEvent onStartTimer;

    void Start()
    {
        onStartTimer?.Invoke();
    }

    public void Explode()
    {
        IBomb bomb = new Bomb(50);

        Fire fireDecorator = new Fire(10);

        fireDecorator.Decorate(bomb);

        Ice iceDecorator = new Ice(5);

        iceDecorator.Decorate(bomb);

        bomb.Explode();
    }
}
