using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 5.0f;

    private float currentRotationY = 10.0f;

    void LateUpdate()
    {
        if (target != null)
        {
            float mouseX = Input.GetAxis("Mouse X");
            currentRotationY += mouseX * rotationSpeed;
            
            target.rotation = Quaternion.Euler(0, currentRotationY, 0);
            transform.position = target.position;
            transform.rotation = Quaternion.Euler(0, target.eulerAngles.y, 0);
        }
    }
}
