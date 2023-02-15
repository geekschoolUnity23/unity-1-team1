using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheRadioactiveZone : MonoBehaviour
{
    public HpSystem hpSysteam;
    public Animator animator;
    public AudioSource GeigerSource;
    public bool canDamageInZone = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(ToDamage());
            GeigerSource.Play();
            animator.SetBool("IsInZone", true);
            canDamageInZone = true;
        }
    }

    private IEnumerator ToDamage()
    {
        //Отнимаем 1ед здоровья пока здоровье есть или пока корутина не будет остановлена
        while (hpSysteam.currentHealth > 0)
        {
            hpSysteam.GetDamage(1);
   
            yield return new WaitForSeconds(3.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StopAllCoroutines();
            GeigerSource.Stop();
            animator.SetBool("IsInZone", false);
            canDamageInZone = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
