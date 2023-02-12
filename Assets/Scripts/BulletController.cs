using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BulletController : MonoBehaviour
{
    
    public float damage = 2f;
    public float firstRate = 1f;
    public float range = 20f;
    public float force = 155;
    public ParticleSystem muzzleFlash;
    public AudioClip shotSFX;
    public AudioSource _audioSource;
    public Transform bulletSpawn;
    public Camera _cam;
    public Animator animator;
    public Animator animatorAK47;
    public Animator akReloadAnim;
    public Animator animatorMakarov;
    private float nextFire = 0f;
    public GameObject hitEffect;
    [SerializeField] int weaponDamage;
    public int patronsCountMax = 30;
    public int patronsCountCurrent;
    public int StoreMachineMax = 10;
    public int StoreMachineCurrent;
    public bool isReolad = true;
    public bool isCanShoot = true;
    public Text patronsText;
    public Text StoresText;




    // Start is called before the first frame update
    void Start()
    {
        patronsCountCurrent = patronsCountMax;
        StoreMachineCurrent = StoreMachineMax;
    }

    // Update is called once per frame
    void Update()
    {
        patronsText.text = patronsCountCurrent.ToString();
        StoresText.text = StoreMachineCurrent.ToString();

        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            if (patronsCountCurrent > 0)
            {
                if(isCanShoot == true)
                {
                    //nextFire = Time.time * 1f / firstRate;
                    Shoot();
                    patronsCountCurrent--;
                    animator.SetBool("GunShake", true);
                    animatorAK47.SetBool("AkShake", true);
                    animatorMakarov.SetBool("MakarovShake", true);
                }
            }
        }
        else
        {
            animatorAK47.SetBool("AkShake", false);
            animator.SetBool("GunShake", false);
            animatorMakarov.SetBool("MakarovShake", false);
        }

        if (Input.GetKeyDown(KeyCode.R) || patronsCountCurrent <= 0)
        {
            if(StoreMachineCurrent > 0 && patronsCountCurrent < patronsCountMax)
            {
                if(isReolad == true)
                {
                    akReloadAnim.SetTrigger("Reload");
                }
            }
        }
    }

    public void Reload()
    {
        patronsCountCurrent = patronsCountMax;
        StoreMachineCurrent--;
    }

    void IsReloadTrue()
    {
        isCanShoot = true;
        isReolad = true;
    }
    void IsReloadfalse()
    {
        isCanShoot = false;
        isReolad = false;
    }

    void Shoot()
    {
         muzzleFlash.Play();
        _audioSource.PlayOneShot(shotSFX);
        //Instantiate(muzzleFlash, bulletSpawn.position, bulletSpawn.rotation);
        RaycastHit hit;
        if (Physics.Raycast(_cam.transform.position, _cam.transform.forward, out hit, range))
        {
            
            Debug.Log("shot");

            GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
            if (hit.transform.gameObject.GetComponent<HpSystemEnemy>())
                hit.transform.gameObject.GetComponent<HpSystemEnemy>().GetDamage(weaponDamage);
            Destroy(impact, 2f);
            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);
            }
        }
    }
}
