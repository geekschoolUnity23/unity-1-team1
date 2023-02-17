using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartQuest : MonoBehaviour
{
    public GameObject QuestPosition;
    public GameObject Marker;
    public GameObject Marker2;
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
            if(isInZone == true)
            {
                QuestPosition.SetActive(true);
                Marker.SetActive(true);
                Marker2.SetActive(false);
            }

        }
    }
}
