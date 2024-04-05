using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float playerSpeed = 1;
    [SerializeField] public bool talking = false;
    void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if(!talking) 
                rb.MovePosition(rb.position + (new Vector2(x, y) * playerSpeed * Time.deltaTime));
        }
    }
    
}
