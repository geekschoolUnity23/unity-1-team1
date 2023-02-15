using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ActTwoMutant : MonoBehaviour
{

    public HpSystemEnemy HpSystemEnemy;
    public NavMeshAgent navMesh;
    public GameObject colider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //private IEnumerator ToDamage()
    //{
        //colider.SetActive(false);
        //navMesh.speed -= 20;
        //yield return new WaitForSeconds(3.0f);
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        if(HpSystemEnemy.currentHealth <= 35)
        {
            //colider.SetActive(true);
            navMesh.speed += 40;
        }
    }
}
