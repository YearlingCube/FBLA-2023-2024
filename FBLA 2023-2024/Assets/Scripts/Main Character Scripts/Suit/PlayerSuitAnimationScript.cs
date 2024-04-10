using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSuitAnimationScript : MonoBehaviour
{
    [SerializeField]
    private Animator PlayerAnimator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PlayerAnimator.SetBool("BackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            PlayerAnimator.SetBool("BackWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PlayerAnimator.SetBool("BackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            PlayerAnimator.SetBool("BackWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerAnimator.SetBool("BackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            PlayerAnimator.SetBool("BackWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PlayerAnimator.SetBool("BackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            PlayerAnimator.SetBool("BackWalk", false);
        }


    }
}
