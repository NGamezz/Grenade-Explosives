using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class OnTrigger : MonoBehaviour
{
    [SerializeField] private int targetLayer;
    [SerializeField] private UnityEvent onTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == targetLayer)
        {
            onTrigger?.Invoke();
        }
    }
}
