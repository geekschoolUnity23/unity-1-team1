using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDamageMachete : MonoBehaviour
{
    [SerializeField] int weaponDamage;
    [SerializeField] float weaponRange;
    [SerializeField] Transform rayOrigin;

    public void Hit()
    {
        RaycastHit HitInfo;
        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out HitInfo, weaponRange))
        {
            if (HitInfo.transform.gameObject.GetComponent<HpSystemEnemy>())
                HitInfo.transform.gameObject.GetComponent<HpSystemEnemy>().GetDamage(weaponDamage);
        }
    }
}
