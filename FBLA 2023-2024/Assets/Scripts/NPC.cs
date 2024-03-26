using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private DialogueDisplayer DD;
    [SerializeField] private DialogueObject startDialogue;
    [SerializeField] private DialogueObject endDialogue;
    [SerializeField] private GameManagerLevel2 GM;
    public bool BirdGame = false;
    public bool EndMoveBool = false;

    public void StartMove()
    {
        animator.SetBool("Start", true);
    }
    public void DisplayStart()
    {
        Debug.Log("Play Dialogue");
        DD.DisplayDialogue2(startDialogue, this);
    }
    public void EndMove()
    {
        animator.SetBool("Start", false);
        animator.SetBool("End", true);
    }
    private void Update()
    {
        if (BirdGame)
        {
            GM.FBLABirdStart();
            BirdGame = false;
        }
        if(EndMoveBool)
            EndMove();
    }
}
