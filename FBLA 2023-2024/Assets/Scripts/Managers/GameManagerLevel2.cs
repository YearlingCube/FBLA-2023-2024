using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FBLABirdStart();
        }
        if(StartBox.active == true)
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
        FBLABirdAnimator.SetBool("Up", true);
        FBLABirdAnimator.SetBool("Down", false);

        Chain1.SetActive(false);
        Chain2.SetActive(false);
        FBLABird.SetActive(false);

        StartBox.SetActive(false);
        Score.SetActive(false);
    }
}
