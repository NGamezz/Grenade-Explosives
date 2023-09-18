using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    void Start()
    {
        IBomb bomb = new Bomb(50);

        Fire fireDecorator = new Fire(10);

        fireDecorator.Decorate(bomb);

        Ice iceDecorator = new Ice(5);

        iceDecorator.Decorate(bomb);

        bomb.Explode();
    }
}
