using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDialogueScript : MonoBehaviour
{
    [SerializeField]
    private DialogueDisplayer DD;
    [SerializeField]
    private DialogueObject DialgoueText;
    [SerializeField]
    private bool DialogueOne = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (DialogueOne == false)
            {
                DD.DisplayDialogue(DialgoueText);
                DialogueOne = true;
            }
        }
    }
}
