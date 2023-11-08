using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        //Grabs the ID of the other object, checks for null, stores the other ID
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
        {
            yield break;
        }

        //On collision, checks the ID of both objects to determine if they match
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
