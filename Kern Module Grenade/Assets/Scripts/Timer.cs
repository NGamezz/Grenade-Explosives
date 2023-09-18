using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float Duration = 0.0f;
    [SerializeField] private event System.Action OnEnd;
    [SerializeField] private bool startOnAwake = false;

    private void Start()
    {
        if(startOnAwake == true)
        {
            StartCoroutine(StartTimer());
        }
    }

    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(Duration);

        Debug.Log("Timer Finished");
        OnEnd?.Invoke();
    }
}
