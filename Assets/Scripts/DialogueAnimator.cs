using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator startAnim;
    public DialogueManager dm;
    public DialogueTrigger dialogueTrigger;
    private bool isCanDialogue = false;
    private bool canScip = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            startAnim.SetBool("startOpen", true);
            isCanDialogue = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            startAnim.SetBool("startOpen", false);
            dm.EndDialogue();
            isCanDialogue = false;
        }
    }

    private void Update()
    {
        if (isCanDialogue == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueTrigger.TriggerDialogue();
                canScip = true;
            }

            if (canScip == true)
            {
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    dm.DisplayNextSentence();
                }
            }

        }
    }
}
