using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private DialogueDisplayer DD;
    [SerializeField] private DialogueObject CD;
    [SerializeField] private DialogueObject BD;
    [SerializeField] private GameObject FlashScreen;
    [SerializeField] private CameraShake cameraShakeScript;

    // Objects that need to Disapear
    [SerializeField] private GameObject Judge;
    // Objects that need to Appear
    [SerializeField] private GameObject DeskRubble;
    [SerializeField] private GameObject BrokenWall;
    [SerializeField] private GameObject ReadMeFile;

    public bool FlashBegin = false;
    public bool BossBegin = false;

    public bool BossFightBool = false;

    public void StartDialogueWithJudge()
    {
        DD.DisplayDialogue5(CD, this);
    }
    public void Flash()
    {
        Debug.Log("FLASH!!!!");
        Judge.SetActive(false);
        DeskRubble.SetActive(true);
        BrokenWall.SetActive(true);
        ReadMeFile.SetActive(true);
        FlashScreen.SetActive(true);
        DD.DisplayDialogue6(BD, this);
        cameraShakeScript.shake = 1f;
    }
    public void BossFight()
    {
        Debug.Log("Boss Fight!!!");
        BossFightBool = true;
    }
    private void Update()
    {
        if(FlashBegin)
        {
            Flash();
            FlashBegin = false;
        }
        if(BossBegin) 
        {
            cameraShakeScript.shake = 0f;
            BossFight();
            BossBegin = false;
        }
    }
}
