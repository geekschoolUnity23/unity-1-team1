using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HpSystemEnemy : MonoBehaviour
{
    [SerializeField] int maxHealth;
    [SerializeField] HealthBar healthBar;
    public float currentHealth;
    public Animator animator;
    public AudioClip deathSound;
    public AudioSource damageSource;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetBarValue(currentHealth, maxHealth);
    }

    public void Death()
    {
        Destroy(gameObject);
    }

    public void GetDamage(int _count)
    {
        damageSource.PlayOneShot(deathSound);
        animator.SetTrigger("Damage");
        currentHealth -= _count;
        healthBar.SetBarValue(currentHealth, maxHealth);



        if (currentHealth <= 0)
        {
            animator.SetTrigger("Death");
        }
    }

    private void Update()
    {
        
    }
}
