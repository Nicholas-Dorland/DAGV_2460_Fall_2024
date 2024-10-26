using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextVector3DataBehavior : MonoBehaviour
{
    private Text textObj;
    public Vector3Data obj;
    public GameAction gameActionObj;
    public UnityEvent awakeEvent, raiseEvent;

    protected virtual void Start()
    {
        textObj = GetComponent<Text>();
        awakeEvent.Invoke();
    }

    public void UpdateTextY(Vector3Data obj)
    {
        textObj.text = obj.value.y.ToString(CultureInfo.CurrentCulture);
    }
}