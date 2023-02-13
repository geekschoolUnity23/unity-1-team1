using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange : MonoBehaviour
{
    public GameObject Ak47;
    public GameObject Makarov;
    public GameObject heal;
    public GameObject machete;
    public Animator akAnimator;
    public Animator makarovAnimator;
    public RaiseTheItem raise;
    public BulletController blAk;
    public BulletController blMakarov;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //akAnimator.SetTrigger("AkTaken");
            Ak47.SetActive(true);
            Makarov.SetActive(false);
            heal.SetActive(false);
            machete.SetActive(false);
            blAk.isCanShoot = true;
            blAk.isReolad = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //akAnimator.SetTrigger("AkHide");
            Ak47.SetActive(false);
            Makarov.SetActive(true);
            heal.SetActive(false);
            machete.SetActive(false);
            blMakarov.isCanShoot = true;
            blMakarov.isReolad = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if(raise.quantityHeal > 0)
            {
                //akAnimator.SetTrigger("AkHide");
                Ak47.SetActive(false);
                Makarov.SetActive(false);
                heal.SetActive(true);
                machete.SetActive(false);
            }
            else
            {
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //akAnimator.SetTrigger("AkHide");
            Ak47.SetActive(false);
            Makarov.SetActive(false);
            heal.SetActive(false);
            machete.SetActive(true);
        }
    }
}
