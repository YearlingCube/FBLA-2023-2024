using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private DialogueDisplayer DD;
    [SerializeField] private DialogueObject CD;
    [SerializeField] private DialogueObject BD;

    [SerializeField] private GameObject FlashScreen;
    [SerializeField] private GameObject FadeScreen;
    [SerializeField] private GameObject InstructionScreen;
    [SerializeField] private CameraShake cameraShakeScript;

    // Objects that need to Disapear
    [SerializeField] private GameObject Judge;
    [SerializeField] private GameObject FakePlayer;
    // Objects that need to Appear
    [SerializeField] private GameObject DeskRubble;
    [SerializeField] private GameObject BrokenWall;
    [SerializeField] private GameObject ReadMeFile;
    [SerializeField] private GameObject RealPlayer;
    [SerializeField] private GameObject BossHealthBar;
    [SerializeField] private GameObject PlayerHealthBar;


    public bool FlashBegin = false;
    public bool BossBegin = false;

    public bool BossFightBool = false;
    public bool GameStarting = false;

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
        FakePlayer.SetActive(false);
        RealPlayer.SetActive(true);
        BossHealthBar.SetActive(true);
        PlayerHealthBar.SetActive(true);
        DD.DisplayDialogue6(BD, this);
        cameraShakeScript.shake = 1f;
    }
    public void BossFight()
    {
        Debug.Log("Boss Fight!!!");
        BossFightBool = true;
    }
    private void Start()
    {
        FadeScreen.GetComponent<Animator>().SetTrigger("FadeOut");
    }
    private void Update()
    {
        if(!GameStarting)
        {
            if (Input.GetMouseButtonDown(0))
            {
                FadeScreen.GetComponent<Animator>().SetTrigger("FadeIn");
                InstructionScreen.SetActive(false);
                StartDialogueWithJudge();
                GameStarting = true;
            }
        }
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
