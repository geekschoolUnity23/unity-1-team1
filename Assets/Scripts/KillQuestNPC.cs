using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillQuestNPC : MonoBehaviour
{

    public EnemyCounter enemyCounter;
    public DialogueTrigger dialogueNewMarader1;
    public DialogueTrigger dialogueNewMarader2;
    public DialogueTrigger dialogueNewMutant1;
    public DialogueTrigger dialogueNewMutant2;
    public GameObject WayPointMarader;
    public GameObject WayPointMutant;
    public bool isMutantQuest;
    public bool isQuestMutantEnd = false;
    public bool isQuestMaraderEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMutantQuest == true)
        {
            if (enemyCounter.currentEnemyCountMutant >= enemyCounter.maxEnemyCountMutant)
            {
                dialogueNewMutant1.enabled = false;
                dialogueNewMutant2.enabled = true;
            }
        }
        else
        {
            if (enemyCounter.currentEnemyCountMarader >= enemyCounter.maxEnemyCountMarader)
            {
                dialogueNewMarader1.enabled = false;
                dialogueNewMarader2.enabled = true;
            }
        }
    }
}
