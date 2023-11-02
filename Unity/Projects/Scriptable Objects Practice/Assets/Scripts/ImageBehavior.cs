using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Image))]

public class ImageBehavior : MonoBehaviour
{
    //Declares an Image variable, an instance of the GameAction class, and a UnityEvent.
    private Image imageObj;
    public GameAction updateAction;
    public UnityEvent startEvent, updageImageEvent;

    private void Start()
    {
        imageObj = GetComponent<Image>();
        updateAction.raiseNoArgs += OnUpdate;
        startEvent.Invoke();
    }
}
