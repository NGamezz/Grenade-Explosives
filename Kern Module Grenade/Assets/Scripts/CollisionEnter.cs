using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEnter : MonoBehaviour
{
    [SerializeField] private UnityEvent OnColision;
    [SerializeField] private int layerToHit;
    [SerializeField] private int layerToAvoid;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == layerToHit && collision.gameObject != this.gameObject && collision.gameObject.layer != layerToAvoid)
        {
            OnColision?.Invoke();
        }
    }
}
