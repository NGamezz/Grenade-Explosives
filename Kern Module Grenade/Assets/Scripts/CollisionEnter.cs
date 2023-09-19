using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEnter : MonoBehaviour
{
    [SerializeField] private UnityEvent OnColision;
    [SerializeField] private int layerMask;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == layerMask && collision.gameObject != this.gameObject)
        {
            OnColision?.Invoke();
        }
    }
}
