using UnityEngine;
using UnityEngine.Events;

public class MonoUpdateEvent : MonoBehaviour
{
    public UnityEvent updateEvent;

    void Update()
    {
        updateEvent.Invoke();
    }
}
