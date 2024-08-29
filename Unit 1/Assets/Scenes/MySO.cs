using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*************************************************************************
 * This creates Scriptable Objects that manage inventory for a character
 * between scenes.
 ************************************************************************/

[CreateAssetMenu]

public class Vector3Data : ScriptableObject
{
    public string[] bag;
    public int spot = 0;        // Keep track of where in the bag we are.

    // Put an item into the bag.
    public void AddItem(string item)
    {
        bag[spot] = item;
        spot++;
    }

    // Take the recent item out of the bag.
    public void UseItem()
    {
        bag[spot] = " ";
        spot--;
    }

    // Check what is in the bag.
    public void CheckItem(int num)
    {
        Debug.Log(bag[num]);
    }
}
