using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private DialogueDisplayer DD;
    [SerializeField] private DialogueObject CD;
    [SerializeField] private GameObject FlashScreen;

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
