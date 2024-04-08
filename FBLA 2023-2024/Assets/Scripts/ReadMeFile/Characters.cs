using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    public float timeToDestruct;

    [SerializeField] Rigidbody2D rb;

    [SerializeField] public float Speed;
    [SerializeField] public float horizontal;
    [SerializeField] public float vertical;

    private void Start()
    {
        
    }
    void FixedUpdate()
    {
        if (timeToDestruct <= 0)
        {
            Destroy(gameObject);
        }
        else 
        {
            rb.MovePosition(rb.position + (new Vector2(horizontal, vertical) * Speed * Time.deltaTime));
            timeToDestruct -= Time.deltaTime;
        }
    }
}
