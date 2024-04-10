using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator PlayerAnimator;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            PlayerAnimator.SetBool("PlayerBackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            PlayerAnimator.SetBool("PlayerBackWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PlayerAnimator.SetBool("PlayerFrontWalk", true);
        }else if(Input.GetKeyUp(KeyCode.DownArrow)) 
        {
            PlayerAnimator.SetBool("PlayerFrontWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerAnimator.SetBool("PlayerSideWalk", true);
            this.GetComponent<SpriteRenderer>().flipX = false;
        }else if (Input.GetKeyUp(KeyCode.RightArrow)) 
        {
            PlayerAnimator.SetBool("PlayerSideWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PlayerAnimator.SetBool("PlayerSideWalk", true);
            this.GetComponent<SpriteRenderer>().flipX = true;
        }else if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            PlayerAnimator.SetBool("PlayerSideWalk", false);
        }


    }
}
