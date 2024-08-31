using UnityEngine;
using UnityEngine.UI;

/*************************************************************************
 * This creates Scriptable Objects that hold a Int value between scenes, 
 * good for health/scores/levels/waves.
 ************************************************************************/

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public float value;

    // Modify the value when an attached object is interacted with.
    public void UpdateValue(int num)
    {
        value += num;
    }

    // Replace the value with a different number.
    public void ReplaceValue(int num)
    {
        value = num;
    }

    // Show an image based on the value (not-full health bar).
    public void DisplayImage(Image img)
    {
        img.fillAmount = value;
    }

    // Show the number as a text object.
    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}
