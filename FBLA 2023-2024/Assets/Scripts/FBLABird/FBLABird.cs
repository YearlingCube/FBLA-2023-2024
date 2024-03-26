using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FBLABird : MonoBehaviour
{
    [SerializeField]
    private GameManagerLevel2 GM;
    //private UIManager UI;

    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private SpriteRenderer SR;


    public Sprite Flap;
    public Sprite NotFlap;

    [SerializeField] private float Speed;
    public float animationTime = 3;
    private float waitTime;

    public bool gameOver = false;

    private void Update()
    {
        if (!gameOver)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (!gameOver)
            {
                if (Time.time > waitTime)
                {
                    SR.sprite = NotFlap;
                }
                if (rb.velocity.y < 0)
                    transform.eulerAngles = new Vector3(0, 0, -45);
                else
                    transform.eulerAngles = new Vector3(0, 0, 30);
                    

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SR.sprite = Flap;
                    waitTime = Time.time + animationTime;
                    rb.velocity = new Vector2(rb.velocity.x, Speed);
                }
                //Debug.Log(Time.time > animationTime);
            }
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }

    }
    public void GameOver()
    {
        rb.velocity = Vector2.zero;
        gameOver = true;
        GM.GameOver();
        Debug.Log("Game Over");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chain")
        {
            GameOver();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("Score Add");
            GM.AddScore();
        }
    }
}
