using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameActions : ScriptableObject
{
    public UnityAction raise;

    public void RaiseAction()
    {
        raise?.Invoke();
    }
}
