using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillQuest : MonoBehaviour
{
    public GameObject enemyCount;
    public GameObject enemyPosition;
    public GameObject Marker;
    private bool isInZone;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInZone = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            enemyCount.SetActive(true);
            enemyPosition.SetActive(true);
            Marker.SetActive(true);
        }
    }
}
