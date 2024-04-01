using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private DialogueDisplayer DD;
    [SerializeField] private DialogueObject CD;
    [SerializeField] private GameObject FlashScreen;

    // Objects that need to Disapear
    [SerializeField] private GameObject Judge;
    // Objects that need to Appear
    [SerializeField] private GameObject DeskRubble;
    [SerializeField] private GameObject BrokenWall;

    public bool FlashBegin = false;
    public void StartDialogueWithJudge()
    {
        DD.DisplayDialogue5(CD, this);
    }
    public void Flash()
    {
        Debug.Log("FLASH!!!!");
        FlashScreen.SetActive(true);

    }
    private void Update()
    {
        if(FlashBegin)
        {
            Flash();
            FlashBegin = false;
        }
    }
}
