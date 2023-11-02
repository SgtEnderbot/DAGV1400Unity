using UnityEngine;

public class GameObjectDisabler : MonoBehaviour
{

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
