using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDialogueScript : MonoBehaviour
{
    [SerializeField]
    private DialogueDisplayer DD;
    [SerializeField]
    private GameManagerLevel1 GM;
    [SerializeField]
    private CharacterMovement Player;
    [SerializeField]
    private DialogueObject DialgoueText;
    [SerializeField]
    public bool Dialogue = false;
    public bool talkingbool = true;

    private void Update()
    {
        if(talkingbool == false)
        {
            Player.talking = false;
            talkingbool = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (Dialogue == false)
            {
                Player.talking = true;
                DD.DisplayDialogue4(DialgoueText, this);

               
            }
        }
    }
}
