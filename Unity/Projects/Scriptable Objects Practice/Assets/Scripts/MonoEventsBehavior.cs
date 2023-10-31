using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;


    void Awake()
    {
        awakeEvent.Invoke();
    }

    void Start()
    {
        startEvent.Invoke();
    }

    void OnDisable()
    {
        disableEvent.Invoke();
    }
}
