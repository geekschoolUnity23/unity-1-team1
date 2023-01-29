using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealScript : MonoBehaviour
{
    private float nextHeal = 20f;
    public HpSystem hp;
    public int healHP;
    public RaiseTheItem raise;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(raise.quantityHeal > 0)
        {
            if (hp.currentHealth < hp.maxHealth)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    raise.quantityHeal--;
                    hp.currentHealth = hp.maxHealth;
                    hp.healthBar.SetBarValue(hp.currentHealth, hp.maxHealth);
                }
            }
            else
            {
                return;
            }
        }
        
    }
}
