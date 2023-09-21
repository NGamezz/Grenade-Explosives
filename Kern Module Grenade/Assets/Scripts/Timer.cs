using System.Collections;
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

    public void ByPassTimer()
    {
        OnEnd?.Invoke();
        StopAllCoroutines();
    }

    public void StartTimer()
    {
        StopAllCoroutines();
        StartCoroutine(StartTimerCount());
    }

    private IEnumerator StartTimerCount()
    {
        yield return new WaitForSeconds(Duration);

        Debug.Log("Timer Finished.");
        OnEnd?.Invoke();
    }
}
