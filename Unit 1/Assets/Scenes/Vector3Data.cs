using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*************************************************************************
 * This creates Scriptable Objects that manage movement for an object
 * between scenes. Good for room transitions.
 ************************************************************************/

[CreateAssetMenu]

public class Vector3Data : ScriptableObject
{
    public Vector3 vector;

    // Move the attached object forward (z-axis).
    public void MoveForward()
    {
        vector += Vector3.forward * Time.deltaTime;
    }

    // Move the attached object backward (-z-axis).
    public void MoveBackward()
    {
        vector += Vector3.back * Time.deltaTime;
    }

    // Move the attached object right (x-axis).
    public void MoveRight()
    {
        vector += Vector3.right * Time.deltaTime;
    }

    // Move the attached object left (-x-axis).
    public void MoveLeft()
    {
        vector += Vector3.left * Time.deltaTime;
    }

    // Move the attached object up (y-axis).
    public void MoveUp()
    {
        vector += Vector3.up * Time.deltaTime;
    }

    // Move the attached object down (-y-axis).
    public void MoveDown()
    {
        vector += Vector3.down * Time.deltaTime;
    }
}
