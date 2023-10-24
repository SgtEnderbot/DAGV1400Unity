using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{

    [SerializeField] private FloatData healthValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ApplyHealth(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void ApplyHealth(GameObject player)
    {
        HealthController healthController = player.GetComponent<HealthController>();

        if (healthController != null)
        {
            healthController.AddHealth(healthValue.Value);
        }
    }

}
