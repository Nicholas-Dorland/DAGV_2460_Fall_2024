using UnityEngine;
using UnityEngine.Events;


public class CollectableEvents : MonoBehaviour
{
    public UnityEvent awakeEvent, triggerEnterEvent, disableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
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
