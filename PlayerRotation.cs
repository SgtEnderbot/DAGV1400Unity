using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // Adjust this value as needed

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 newRotation = transform.rotation.eulerAngles + new Vector3(0, mouseX * rotationSpeed, 0);
        transform.rotation = Quaternion.Euler(newRotation);
    }
}
