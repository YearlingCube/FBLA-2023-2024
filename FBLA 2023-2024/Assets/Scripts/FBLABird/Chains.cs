using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chains : MonoBehaviour
{
    [SerializeField]
    private int speed = 1;

    [SerializeField] private GameManagerLevel2 GM;

    private Vector3 spawn;


    private void Start()
    {
        speed = -speed;
        spawn = transform.position;
        this.transform.position = new Vector3(transform.position.x, Random.Range(-3.58f, -0.68f), 0);

    }
    void Update()
    {
        if (GM.FBLABirdStartGame == true)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
            if (transform.position.x <= 0)
            {
                this.transform.position = new Vector3(19.65f, Random.Range(-3.58f, -0.68f), 0);

            }
        }
    }
    public void ResetChain()
    {
        this.transform.position = spawn;
    }
    
}
