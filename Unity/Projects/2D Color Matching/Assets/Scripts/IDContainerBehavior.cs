using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class IDContainerBehavior : MonoBehaviour
{
    //Gives object an ID
    public ID idObj;
    //Creates the startEvent
    public UnityEvent startEvent;

    public void Start()
    {
        startEvent.Invoke();
    }
}