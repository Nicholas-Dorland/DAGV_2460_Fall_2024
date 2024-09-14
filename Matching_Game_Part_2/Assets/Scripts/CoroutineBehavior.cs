using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehavior : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Late Start");
    }
}
