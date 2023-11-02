using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerExitEvent;

    //Should allow objects to "invoke" an action upon contact
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    //Should allow objects to "invoke" an action upon leaving contact
    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}
