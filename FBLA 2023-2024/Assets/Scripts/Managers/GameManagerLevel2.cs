using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerLevel2 : MonoBehaviour
{
    [SerializeField] private GameObject Chain1;
    [SerializeField] private GameObject Chain2;
    [SerializeField] private GameObject FBLABird;
    [SerializeField] private GameObject Stand;
    [SerializeField] public bool FBLABirdStartGame = false;
    [SerializeField] private Animator FBLABirdAnimator;
    [SerializeField] private GameObject StartBox;
    [SerializeField] private GameObject Score;
    [SerializeField] public int score = 0;
    [SerializeField] public int totalScore = 0;
    [SerializeField] private NPC[] NPCS;
    [SerializeField] private NPC currentNPC;
    [SerializeField] private int currentNPCIndex = 0;


    private void Start()
    {
        currentNPC = NPCS[0];
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentNPC.StartMove();

        }
        if (StartBox.activeSelf == true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                FBLABirdStartGame = true;
                StartBox.SetActive(false);
                FBLABird.GetComponent<FBLABird>().gameOver = false;
            }
        }

    }
    public void FBLABirdStart()
    {
        currentNPC.transform.gameObject.SetActive(false);
        FBLABirdAnimator.SetBool("Up", false);
        FBLABirdAnimator.SetBool("Down", true);


        Chain1.SetActive(true);
        Chain2.SetActive(true);
        FBLABird.SetActive(true);

        StartBox.SetActive(true);
        Score.SetActive(true);
    }
    public void GameOver()
    {
        Debug.Log("- - Set Transition - -");
        FBLABirdAnimator.SetBool("Down", false);
        FBLABirdAnimator.SetBool("Up", true);

        FBLABirdStartGame = false;

        Debug.Log("- - Score Changes - -");
        totalScore += score;
        score = 0;
        Score.GetComponent<TextMeshProUGUI>().text = (score).ToString();

        Debug.Log("- - Reseting Chains - -");
        Chain1.GetComponent<Chains>().ResetChain();
        Chain2.GetComponent<Chains>().ResetChain();

        Debug.Log("- - Deactivating UI and FBLA Bird - -");
        FBLABird.SetActive(false);
        StartBox.SetActive(false);
        Score.SetActive(false);

        

        Debug.Log("- - NPC Activation - -");
        currentNPC.transform.gameObject.SetActive(true);

        Debug.Log("- - NPC Math - -");
        currentNPCIndex += 1;
        if (currentNPCIndex >= NPCS.Length)
        {
            currentNPC.EndMoveBool = true;
            NPCDone();
        }else
        {
            currentNPC.EndMoveBool = true;
            currentNPC = NPCS[currentNPCIndex];
        }
    }
    void NPCDone()
    {
        Debug.Log("NPCS Done!");
    }
    public void AddScore()
    {
        score += 1;
        Score.GetComponent<TextMeshProUGUI>().text = (score).ToString();
    }
}
