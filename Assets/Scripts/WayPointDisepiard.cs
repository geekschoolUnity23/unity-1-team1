using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointDisepiard : MonoBehaviour
{

    public GameObject WayPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WayPoint.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WayPoint.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
