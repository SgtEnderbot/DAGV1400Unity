using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public int ammoValue = 1;
    public int currentAmmo;

    public void AddAmmo(int ammoAmount)
    {
        currentAmmo += ammoValue;
    }
}
