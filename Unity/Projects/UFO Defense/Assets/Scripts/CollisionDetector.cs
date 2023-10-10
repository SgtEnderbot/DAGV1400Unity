using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    //Detects when colliding with another object and determines if it is a laser. If so, it destroys both objects.
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Laser")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

}
