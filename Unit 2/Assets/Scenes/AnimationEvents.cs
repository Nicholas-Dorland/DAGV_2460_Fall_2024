using UnityEngine;
using UnityEngine.Events;


public class AnimationEvents : MonoBehaviour
{
    public UnityEvent awakeEvent, disableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
