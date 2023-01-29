using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutantFaseTwo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<HpSystem>().GetDamage(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
