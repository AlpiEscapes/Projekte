using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Dieses Script muss auf den Player gezogen werden

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    //Um wieviel sollen die hotkeys heilen oder schaden machen
    public int HealValue;
    public int DamageValue;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(DamageValue);
        }
        if (Input.GetKeyDown(GameManager.GM.heal))
        {
            Heal(HealValue);
        }

    }

    void TakeDamage(int damage)
    {
        if (currentHealth > 0)
        {
            currentHealth -= damage;

            healthBar.SetHealth(currentHealth);

            if (currentHealth < 1)
            {
                Dead();
            }
        }
        
    }

    void Heal(int damage)
    {
        if (currentHealth < 100)
        {
            currentHealth += damage;

            healthBar.SetHealth(currentHealth);
        }
    }
    void Dead()
    {
        Debug.Log("Taken by the Styx");
    }
}
