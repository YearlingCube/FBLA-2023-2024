using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : StateMachineBehaviour
{
    public double timer;
    public double setTimer = 4;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = setTimer;
        animator.GetComponent<ReadMeFileHealth>().isInvulnerable = false;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (timer <= 0)
        {
            animator.SetTrigger("Idle");
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Rest");
        timer = setTimer;
        animator.GetComponent<ReadMeFileHealth>().isInvulnerable = true;
    }
}