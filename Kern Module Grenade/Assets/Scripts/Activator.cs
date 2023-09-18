using UnityEngine;

public class Activator : MonoBehaviour
{
    public void OnStart()
    {
        IBomb bomb = new Bomb(50);

        Fire fireDecorator = new Fire(10);

        fireDecorator.Decorate(bomb);

        Ice iceDecorator = new Ice(5);

        iceDecorator.Decorate(bomb);

        bomb.Explode();
    }
}
