using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCon : MonoBehaviour
{
    public Collider damageArea;

    public void OnDamageArea()
    {
        damageArea.gameObject.SetActive(true);
    }

    public void OffDamageArea()
    {
        damageArea.gameObject.SetActive(false);
    }
}
