using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheakPoint : MonoBehaviour
{
    public GameObject flag;
    Vector3 spawnPoint;
    public GameObject Player;
    public Animator deathAnimator;
    public HpSystem hpSystem;

    private void Start()
    {
        spawnPoint = Player.transform.position;
    }

    public void Revival()
    {
        deathAnimator.SetBool("Death", false);
        Player.transform.position = spawnPoint;
        Cursor.lockState = CursorLockMode.Locked;
        hpSystem.currentHealth = hpSystem.maxHealth;
        hpSystem.healthBar.SetBarValue(hpSystem.currentHealth, hpSystem.maxHealth);
        hpSystem.isDie = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            spawnPoint = flag.transform.position;
        }
    }
}
