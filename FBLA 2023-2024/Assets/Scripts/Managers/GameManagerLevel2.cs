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
    }
}
