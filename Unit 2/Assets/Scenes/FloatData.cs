using UnityEngine;

/*************************************************************************
 * This creates Scriptable Objects that hold a Float value between scenes, 
 * good for health/scores.
 ************************************************************************/

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;

    // Modify the value when an attached boject is interacted with.
    public void UpdateValue(float num)
    {
        value += num;
    }
}
