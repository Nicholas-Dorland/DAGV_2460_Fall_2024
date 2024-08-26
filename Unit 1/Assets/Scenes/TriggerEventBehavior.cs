using UnityEngine;
using UnityEngine.Events;

/*************************************************************************
 * Cause an attached object's Script to happen when it collides with 
 * another object's collider.
 ************************************************************************/

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
