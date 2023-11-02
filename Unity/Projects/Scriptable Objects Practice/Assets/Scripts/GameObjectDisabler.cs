using UnityEngine;

public class GameObjectDisabler : MonoBehaviour
{

    //As far as I understand from the lesson, this should disable the game object the script is attached to.
    //This happens upon contact with ANY object that has the TriggerEnterEvent script attached.

    private void OnEnable()
    {
        var triggerEnterEvent = FindObjectOfType<TriggerEnterEvent>();
        if (triggerEnterEvent != null)
        {
            triggerEnterEvent.triggerExitEvent.AddListener(DisableGameObject);
        }
    }

    private void OnDisable()
    {
        var triggerEnterEvent = FindObjectOfType<TriggerEnterEvent>();
        if (triggerEnterEvent != null)
        {
            triggerEnterEvent.triggerExitEvent.RemoveListener(DisableGameObject);
        }
    }
    private void DisableGameObject()
    {
        gameObject.SetActive(false);
    }
}
