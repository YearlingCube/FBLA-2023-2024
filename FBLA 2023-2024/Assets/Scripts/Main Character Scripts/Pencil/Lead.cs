using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Lead : MonoBehaviour
{
    public float timeToDestruct;

    [SerializeField] Rigidbody2D rb;

    [SerializeField] public float Speed;
    [SerializeField] public float horizontal;
    [SerializeField] public float vertical;
    void Update()
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boss")
        {
            collision.GetComponent<ReadMeFileHealth>().TakeDamage(1);
            Destroy(gameObject);
        }
    }
}
