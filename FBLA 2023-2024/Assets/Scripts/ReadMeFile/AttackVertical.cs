using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class AttackVertical : StateMachineBehaviour
{
    [SerializeField] private Vector3[] AttackSpawnLocation = new Vector3[3];
    [SerializeField] private Sprite[] Characters;
    [SerializeField] private Object Character;
    [SerializeField] private Transform Player;

    [SerializeField] double timer;
    [SerializeField] double setTimer = 4;
    [SerializeField] float CharacterSpeed;

    [SerializeField] double characterTimer;
    double chTimer = 0;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Player = GameObject.FindObjectOfType<PlayerSuitScript>().transform;
        chTimer = characterTimer;
        AttackSpawnLocation[0] = new Vector3(Player.position.x - 4f, 6.79f, 0);
        AttackSpawnLocation[1] = new Vector3(Player.position.x, 6.79f, 0);
        AttackSpawnLocation[2] = new Vector3(Player.position.x + 4f, 6.79f, 0);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        int r = Random.Range(0, 2);
        if(timer <= 0)
        {
            if (r == 0)
                animator.SetTrigger("AttackHorizontal");
            else if (r == 1)
                animator.SetTrigger("Rest");
        }else
        {
            Debug.Log(chTimer);
            if (chTimer <= 0)
            {

                for (int i = 0; i < AttackSpawnLocation.Length; i++)
                {
                    int characterIndex = Random.Range(0, Characters.Length);
                    Object ch = Instantiate(Character, AttackSpawnLocation[i], Quaternion.identity, animator.transform);

                    Debug.Log("BOOM OBJECT BABY!");
                    ch.GetComponent<SpriteRenderer>().sprite = Characters[characterIndex];
                    ch.GetComponent<Characters>().vertical = -1;
                    ch.GetComponent<Characters>().Speed = CharacterSpeed;
                }
                chTimer = characterTimer;
            }
            else
                chTimer -= Time.deltaTime;
            timer -= Time.deltaTime;
        }
    }
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("AttackVertical");
        timer = setTimer;
    }
}
