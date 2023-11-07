using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        //Grabs the ID of the other object, checks for null, stores the other ID
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
        {
            return;
        }
        var otherID = tempObj.idObj;
        //On collision, checks the ID of both objects to determine if they match
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}
