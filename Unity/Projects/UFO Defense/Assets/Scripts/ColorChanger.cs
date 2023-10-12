using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    //Color changing variables
    public float colorChange = 2.0f;
    public float colorRevert = 4.0f;
    public float colorLimit = 6.0f;
    float colorTimer;

    void Update()
    {

        colorTimer += Time.deltaTime;

        //Changes the color of the pick up on a timer
        if (colorTimer >= colorLimit)
        {
        colorTimer -= colorLimit;
        }
        else if (colorTimer >= colorRevert)
        {
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
        else if (colorTimer >= colorChange)
        gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 0);
    }
}
