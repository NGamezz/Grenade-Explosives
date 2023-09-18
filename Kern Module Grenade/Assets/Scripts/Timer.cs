using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float Duration = 0.0f;
    [SerializeField] private UnityEvent OnEnd;
    [SerializeField] private bool startOnAwake = false;

    private void Start()
    {
        if (startOnAwake == true)
        {
            StartTimer();
        }
    }

    public void StartTimer()
    {
        StartCoroutine(StartTimerCountDown());
    }

    private IEnumerator StartTimerCountDown()
    {
        yield return new WaitForSeconds(Duration);

        Debug.Log("Timer Finished");
        OnEnd?.Invoke();
    }
}
