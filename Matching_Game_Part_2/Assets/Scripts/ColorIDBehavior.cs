using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IDContainerBehavoir
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
