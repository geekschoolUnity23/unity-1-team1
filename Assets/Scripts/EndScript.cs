using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EndScript : MonoBehaviour
{
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetTrigger("End");
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
