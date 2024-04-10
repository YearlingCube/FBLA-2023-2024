using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSuitScript : MonoBehaviour
{
    [SerializeField] AnimationManager AM;
    [SerializeField] Slider PlayerHealthBar;

    [SerializeField] GameObject PlayerDeathScreen;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] float playerSpeed = 4;

    [SerializeField] float PlayerHealth = 10;
    [SerializeField] double InvulnerableTimer = 2;
    [SerializeField] bool Invulnerable = false;
    void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            if (AM.BossFightBool)
                rb.MovePosition(rb.position + (new Vector2(x, y) * playerSpeed * Time.deltaTime));
        }
        if(InvulnerableTimer <=0)
        {
            Invulnerable = false;
        }
        else
        {
            InvulnerableTimer -= Time.deltaTime;
        }
        if(PlayerHealth <= 0)
        {
            Debug.Log("YOU DIED LMAO!");
            PlayerDeathScreen.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Characters")
        {
            if (!Invulnerable)
            {
                PlayerHealth -= 1;
                PlayerHealthBar.value = PlayerHealth;
                Invulnerable = true;
                InvulnerableTimer = 2;
            }
        }
    }

}