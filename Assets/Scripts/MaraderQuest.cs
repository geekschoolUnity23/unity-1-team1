using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaraderQuest : MonoBehaviour
{
    private bool isInZone;
    public EnemyCounter enemyCounter;
    public GameObject Counter;
    public GameObject MarkerKillMarader;
    public GameObject MaraderKillQuestPosition;
    public GameObject MarkerToNPC;
    public GameObject MarkerEnd;
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
            if (isInZone == true)
            {
                if (enemyCounter.currentEnemyCountMutant >= enemyCounter.maxEnemyCountMutant)
                {
                    MarkerKillMarader.SetActive(false);
                    MarkerToNPC.SetActive(true);
                    dialogueTriggerBack.enabled = false;
                    dialogueTriggerNext.enabled = true;
                    if (Input.GetKeyDown(KeyCode.Tab))
                    {
                        MarkerToNPC.SetActive(false);
                        MarkerEnd.SetActive(true);
                    }
                }
                else
                {
                    Counter.SetActive(true);
                    MaraderKillQuestPosition.SetActive(true);
                    MarkerKillMarader.SetActive(true);
                }
            }
        }
    }
}
