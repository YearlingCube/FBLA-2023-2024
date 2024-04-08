using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : StateMachineBehaviour
{
    public double setTimer = 4;
    public double timer;

    AnimationManager animationManager;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = setTimer;
        animationManager = GameObject.FindObjectOfType<AnimationManager>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (animationManager.BossFightBool)
        {
            if (timer <= 0)
            {
                int r = Random.Range(0, 2);
                if (r == 0)
                {
                    animator.SetTrigger("AttackHorizontal");
                }
                else
                {
                    animator.SetTrigger("AttackVertical");
                }
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Idle");
        timer = setTimer;
    }
}
