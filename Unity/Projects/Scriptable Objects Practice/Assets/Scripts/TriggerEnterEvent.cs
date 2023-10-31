using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriiiggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
