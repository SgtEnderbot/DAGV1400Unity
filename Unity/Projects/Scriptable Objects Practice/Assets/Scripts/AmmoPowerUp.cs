using UnityEngine;

public class AmmoPowerUp : MonoBehaviour
{
    [SerializeField] private IntData ammoValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AddAmmo(other.gameObject);

            Destroy(gameObject, 0.2f);
        }
    }

    public void AddAmmo(GameObject player)
    {
        WeaponController weaponController = player.GetComponent<WeaponController>();

        if(weaponController != null)
        {
            weaponController.AddAmmo(ammoValue.Value);
            Debug.Log("Ammo: " + weaponController.currentAmmo);
        }
    }
}