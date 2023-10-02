using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : StatSystem
{


    private GameObject player;

    public GameObject Player { get => player; set => player = value; }
    [SerializeField] private int damage;

    public abstract void movementBehaviour(); // determines the movementBehaviour of the enemy unit
    public abstract void combatBehaviour(); // determines combatBehaviour of the enemy unit
    public abstract void dealDmg(); // is the function that manages how much dmg the enemy unit deals to the player or to other units around him
    public abstract void death();   // is the method that gets called, upon death
    public abstract void dropchance();   // determines the chance, or the item that gets dropped upon defeating this unit

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerHolder");
    }
}
