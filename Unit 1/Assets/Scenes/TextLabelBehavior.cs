using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

/*************************************************************************
 * Manage a Text object and provide a means for the text to update/change.
 ************************************************************************/

[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{
    public Text label;
    public FloatData dataObj;

    public void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }

    // Update the Text when called.
    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
