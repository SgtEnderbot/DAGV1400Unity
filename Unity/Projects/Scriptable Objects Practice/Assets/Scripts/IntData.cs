using UnityEngine;

[CreateAssetMenu(fileName = "New Int Data", menuName = "Int Data")]

public class IntData : ScriptableObject
{
    public int value;

    public int Value
    {
        get {return value;}
    }
}
