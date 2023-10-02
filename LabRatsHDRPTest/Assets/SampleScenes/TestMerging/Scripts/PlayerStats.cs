using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats : StatSystem
{
    
    public HP_Script healthBar; //Holds the healthbar object
    [SerializeField] private int healValue; 
    [SerializeField] private int damageValue;
    
    private int healItemAmount;



    public int HealValue { get => healValue; set => healValue = value; }
    public int DamageValue { get => damageValue; set => damageValue = value; }
    public int HealItemAmount { get => healItemAmount; set => healItemAmount = value; }

    public void UpdateHpBar()
    {
        healthBar.SetHealth(CurrentHealth);
    }


    public void EndHealing()
    {
        healItemAmount--;
        GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameHandler>().PlayerHeal(healValue);
        gameObject.GetComponent<Animator>().SetBool("isPunching", false);
    }


}
