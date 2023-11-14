using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;

    public void CreateInstance ()
    {
    }

    public void CreateInstance (Vector3Data obj)
    {
    }

    public void CreateInstanceFromList (Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
        num ++;
        if (num > obj.vector3List.Count)
        {
            num = 0;
        }
    }
}
