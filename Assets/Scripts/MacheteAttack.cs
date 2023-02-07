using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacheteAttack : MonoBehaviour
{
    public Animator animator;
    public float reloadAttack = 1.16f;
    private bool isReloaded = true;
    public bool isAttack = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator TestCoroutine()
    {
        yield return new WaitForSeconds(reloadAttack);
        isReloaded = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isAttack = true;
            if (isReloaded == true)
            {
                animator.SetTrigger("Attack");
                isReloaded = false;
                StartCoroutine(TestCoroutine());
            }
        }
    }
}
