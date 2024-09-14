using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/*************************************************************************
 * Manage a Text object and provide a means for the text to update/change.
 ************************************************************************/

[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{
    private Text label;
    public UnityEvent startEvent;

    public void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    // Update the Text when called.
    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}
