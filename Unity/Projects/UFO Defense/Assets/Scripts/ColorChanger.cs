using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    //Color variables
    public Material color1;
    public Material color2;
    public GameObject Ability;

    //Color changing variables
    public float colorChange = 0.2f;
    public float colorRevert = 0.4f;
    public float colorLimit = 0.8f;
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
        Ability.GetComponent<MeshRenderer>().material = color1;
        }
        else if (colorTimer >= colorChange)
        {
        Ability.GetComponent<MeshRenderer>().material = color2;
        }
    }
}
