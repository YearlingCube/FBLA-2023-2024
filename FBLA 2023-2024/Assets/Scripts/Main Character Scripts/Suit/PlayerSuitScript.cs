using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSuitScript : MonoBehaviour
{
    [SerializeField] AnimationManager AM;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] float playerSpeed = 4;
    void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (AM.BossFightBool)
                rb.MovePosition(rb.position + (new Vector2(x, y) * playerSpeed * Time.deltaTime));
        }
    }

}