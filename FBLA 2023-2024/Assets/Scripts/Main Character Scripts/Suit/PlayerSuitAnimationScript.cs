using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSuitAnimationScript : MonoBehaviour
{
    [SerializeField]
    private Animator PlayerAnimator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerAnimator.SetBool("BackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            PlayerAnimator.SetBool("BackWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerAnimator.SetBool("BackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            PlayerAnimator.SetBool("BackWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerAnimator.SetBool("BackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            PlayerAnimator.SetBool("BackWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerAnimator.SetBool("BackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            PlayerAnimator.SetBool("BackWalk", false);
        }


    }
}
