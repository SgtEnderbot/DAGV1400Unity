using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float value;
    public float amount = 10.0f;

    public void AddHealth(float amount)
    {
        value += amount;
    }
}
