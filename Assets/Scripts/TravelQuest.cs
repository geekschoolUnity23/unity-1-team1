using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelQuest : MonoBehaviour
{
    private bool isInZone;
    public GameObject QuestPosition;
    public GameObject MarkerKillMutant;
    public GameObject MarkerOldQuest;
    public GameObject MarkerNewQuest;
    public CollectQuest collectQuest;
    public DialogueTrigger dialogueTriggerBack;
    public DialogueTrigger dialogueTriggerNext;
    public GameObject IteamCounter;

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
            if (isInZone == true)
            {
                if(collectQuest.currentIteamCount >=collectQuest.maxIteamCount) 
                {
                    MarkerOldQuest.SetActive(true);
                    MarkerNewQuest.SetActive(false);
                    dialogueTriggerBack.enabled = false;
                    dialogueTriggerNext.enabled = true;
                    if (Input.GetKeyDown(KeyCode.Tab))
                    {
                        IteamCounter.SetActive(false);
                        MarkerOldQuest.SetActive(false);
                        MarkerKillMutant.SetActive(true);
                    }
                }
                else
                {
                    IteamCounter.SetActive(true);
                    QuestPosition.SetActive(true);
                    MarkerNewQuest.SetActive(true);
                    MarkerOldQuest.SetActive(false);
                }
            }
        }
    }
}
