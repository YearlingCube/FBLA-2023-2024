using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PencilAttack : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] double settimer = 2;
    [SerializeField] double timer = 0;

    [SerializeField] Object Lead;
    [SerializeField] GameObject LeadLocation;

    [SerializeField] float LeadSpeed = 45;

    [SerializeField] bool canShoot = true;

    public void switchState()
    {
        animator.SetTrigger("Idle");
    }
    
    public void Shoot(Animator animator)
    {
        Object l = Instantiate(Lead, LeadLocation.transform.position, LeadLocation.transform.rotation, gameObject.transform);
        l.GetComponent<Lead>().vertical = 1;
        l.GetComponent<Lead>().Speed = LeadSpeed;
    }
}
