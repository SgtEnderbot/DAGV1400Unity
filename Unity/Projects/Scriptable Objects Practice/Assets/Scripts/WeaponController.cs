using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public int startAmmo = 20;
    public int currentAmmo;
    public float damage = 10.0f;

    void Start()
    {
        currentAmmo = startAmmo;
    }

    public void AddAmmo(int ammoAmount)
    {
        currentAmmo += ammoAmount;
    }
}
