using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDamageEnemy : MonoBehaviour
{
    [SerializeField] int weaponDamage;
    [SerializeField] float weaponRange;
    [SerializeField] Transform rayOrigin;

    public void Hit()
    {
        RaycastHit HitInfo;
        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out HitInfo, weaponRange))
        {
            Debug.Log("shot");
            if (HitInfo.transform.gameObject.GetComponent<HpSystem>())
                HitInfo.transform.gameObject.GetComponent<HpSystem>().GetDamage(weaponDamage);
        }
    }
}
