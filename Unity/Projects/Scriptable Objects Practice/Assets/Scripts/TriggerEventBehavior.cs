using UnityEngine.Events;
using UnityEngine;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
