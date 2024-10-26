using UnityEngine;

public class UpdateHeight : MonoBehaviour
{
    public Vector3Data obj;

    void Update()
    {
        obj.value.y = this.transform.position.y;
    }
}
