using UnityEngine;
using UnityEngine.Events;


public class EnemyEvents : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, triggerEnterEvent, disableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        OnDisable();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
