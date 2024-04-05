using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueDisplayer : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text dialogueText;
    public DialogueObject currentDialogue;
    private IEnumerator MoveThroughDialogue(DialogueObject dialogueObject)
    {
        dialogueBox.SetActive(true);
        for (int i = 0; i < dialogueObject.dialogueLines.Length; i++)
        {
            dialogueText.text = dialogueObject.dialogueLines[i].dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        dialogueBox.SetActive(false);

    }
    private IEnumerator MoveThroughDialogue2(DialogueObject dialogueObject, NPC sender)
    {
        dialogueBox.SetActive(true);
        for (int i = 0; i < dialogueObject.dialogueLines.Length; i++)
        {
            dialogueText.text = dialogueObject.dialogueLines[i].dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        dialogueBox.SetActive(false);
        sender.BirdGame = true;
    }
    private IEnumerator MoveThroughDialogue3(DialogueObject dialogueObject, NPC sender)
    {
        dialogueBox.SetActive(true);
        for (int i = 0; i < dialogueObject.dialogueLines.Length; i++)
        {
            dialogueText.text = dialogueObject.dialogueLines[i].dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        dialogueBox.SetActive(false);
        sender.EndMoveBool2 = true;
    }
    private IEnumerator MoveThroughDialogue4(DialogueObject dialogueObject, NpcDialogueScript sender)
    {
        dialogueBox.SetActive(true);
        for (int i = 0; i < dialogueObject.dialogueLines.Length; i++)
        {
            dialogueText.text = dialogueObject.dialogueLines[i].dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        dialogueBox.SetActive(false);
        sender.Dialogue = true;
        sender.talkingbool = false;
    }
    private IEnumerator MoveThroughDialogue4(DialogueObject dialogueObject, AnimationManager sender)
    {
        dialogueBox.SetActive(true);
        for (int i = 0; i < dialogueObject.dialogueLines.Length; i++)
        {
            dialogueText.text = dialogueObject.dialogueLines[i].dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        dialogueBox.SetActive(false);
        sender.FlashBegin = true;
    }
    private IEnumerator MoveThroughDialogue5(DialogueObject dialogueObject, AnimationManager sender)
    {
        dialogueBox.SetActive(true);
        for (int i = 0; i < dialogueObject.dialogueLines.Length; i++)
        {
            dialogueText.text = dialogueObject.dialogueLines[i].dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            //The following line of code makes the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        dialogueBox.SetActive(false);
        sender.BossBegin = true;
    }
    public void DisplayDialogue(DialogueObject dialogueObject)
    {
        StartCoroutine(MoveThroughDialogue(dialogueObject));
    }
    public void DisplayDialogue2(DialogueObject dialogueObject, NPC sender)
    {
        StartCoroutine(MoveThroughDialogue2(dialogueObject, sender));
    }
    public void DisplayDialogue3(DialogueObject dialogueObject, NPC sender)
    {
        StartCoroutine(MoveThroughDialogue3(dialogueObject, sender));
    }
    public void DisplayDialogue4(DialogueObject dialogueObject, NpcDialogueScript sender)
    {
        StartCoroutine(MoveThroughDialogue4(dialogueObject, sender));
    }
    public void DisplayDialogue5(DialogueObject dialogueObject, AnimationManager sender)
    {
        StartCoroutine(MoveThroughDialogue4(dialogueObject, sender));
    }
    public void DisplayDialogue6(DialogueObject dialogueObject, AnimationManager sender)
    {
        StartCoroutine(MoveThroughDialogue5(dialogueObject, sender));
    }
}