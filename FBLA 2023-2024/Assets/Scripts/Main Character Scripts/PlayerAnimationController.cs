using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField]
    private Sprite Player_UpIdle;
    [SerializeField]
    private Sprite Player_DownIdle;
    [SerializeField]
    private Sprite Player_SideIdle;
    [SerializeField]
    private Animator PlayerAnimator;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            PlayerAnimator.SetBool("PlayerBackWalk", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            PlayerAnimator.SetBool("PlayerBackWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerAnimator.SetBool("PlayerFrontWalk", true);
        }else if(Input.GetKeyUp(KeyCode.S)) 
        {
            PlayerAnimator.SetBool("PlayerFrontWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerAnimator.SetBool("PlayerSideWalk", true);
            this.GetComponent<SpriteRenderer>().flipX = false;
        }else if (Input.GetKeyUp(KeyCode.D)) 
        {
            PlayerAnimator.SetBool("PlayerSideWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerAnimator.SetBool("PlayerSideWalk", true);
            this.GetComponent<SpriteRenderer>().flipX = true;
        }else if(Input.GetKeyUp(KeyCode.A))
        {
            PlayerAnimator.SetBool("PlayerSideWalk", false);
        }


    }
}
