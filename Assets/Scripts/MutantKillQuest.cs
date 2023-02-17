using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutantKillQuest : MonoBehaviour
{
    private bool isInZone;
    public EnemyCounter enemyCounter;
    public GameObject Counter;
    public GameObject MarkerKillMutant;
    public GameObject MutantKillQuestPosition;
    public GameObject MarkerToNPC;
    public GameObject MarkerMaraderNPC;
    public DialogueTrigger dialogueTriggerBack;
    public DialogueTrigger dialogueTriggerNext;

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
                if(enemyCounter.currentEnemyCountMutant >= enemyCounter.maxEnemyCountMutant)
                {
                    MarkerKillMutant.SetActive(false);
                    MarkerToNPC.SetActive(true);
                    dialogueTriggerBack.enabled = false;
                    dialogueTriggerNext.enabled = true;
                    if (Input.GetKeyDown(KeyCode.Tab))
                    {
                        MarkerToNPC.SetActive(false);
                        MarkerMaraderNPC.SetActive(true);
                    }
                }
                else
                {
                    Counter.SetActive(true);
                    MutantKillQuestPosition.SetActive(true);
                    MarkerKillMutant.SetActive(true);
                }
            }
        }
    }
}
