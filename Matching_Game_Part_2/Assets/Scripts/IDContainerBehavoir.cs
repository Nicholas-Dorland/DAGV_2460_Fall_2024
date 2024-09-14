using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavoir : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent;

    public void Start()
    {
        startEvent.Invoke();
    }
}
