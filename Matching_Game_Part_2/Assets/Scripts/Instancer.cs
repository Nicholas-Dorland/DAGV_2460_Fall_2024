using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;

    private int num;

    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        for (int i = 0; i < obj.vector3DList.Count; i++)
        {
            Instantiate(prefab, obj.vector3DList[i].value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3DList.Count)
        {
            num = 0;
        }
    }

    public void CreateInstanceFromListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DList.Count);
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
    }
}
