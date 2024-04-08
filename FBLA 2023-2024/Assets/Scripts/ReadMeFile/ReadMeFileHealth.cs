using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadMeFileHealth : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    [SerializeField] private GameObject DeathBoss;
    [SerializeField] private AnimationManager AM;

    [SerializeField] private float BossHealth = 20;

    [SerializeField] public bool isInvulnerable = true;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider.value = BossHealth;
    }
    
    public void TakeDamage(float damage)
    {
        if (isInvulnerable)
            return;

        BossHealth -= damage;

        healthSlider.value = BossHealth;


        if (BossHealth <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Debug.Log("BOSS IS DEAD!!!");
        DeathBoss.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
