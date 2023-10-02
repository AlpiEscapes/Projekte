using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ranged_Unit_Script : BaseEnemy
{
    private NavMeshAgent agent;
    private float distanceToPlayer;
 


    // Start is called before the first frame update
#pragma warning disable CS0108 // Element blendet vererbte Element aus; fehlendes 'new'-Schlüsselwort
    void Start()
#pragma warning restore CS0108 // Element blendet vererbte Element aus; fehlendes 'new'-Schlüsselwort
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.speed = Speed;

        
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        movementBehaviour();
    }


    public override void dealDmg()
    {
        throw new System.NotImplementedException();
    }

    public override void death()
    {
        throw new System.NotImplementedException();
    }

    public override void dropchance()
    {
        throw new System.NotImplementedException();
    }

    public override void movementBehaviour()
    {
        // Ranged Unit is supposed to Stay in range to attack, and move away from the player, as soon as he should come too close
        // agent.remainingDistance() can not be used here, so i created a new variable to measure the distance

        distanceToPlayer = Vector3.Distance(Player.transform.position, this.transform.position);
        //Debug.Log(distanceToPlayer);

        //Checks whether the Player is in Aggro Range, if that is true, he chases the Player
        if (distanceToPlayer >= agent.stoppingDistance && distanceToPlayer <= 25)
        {
            Debug.Log("Ranged : Move Towards Player!");

            agent.SetDestination(base.Player.transform.position);

           
        }
        //Checks whether the Player is in Combat Range, if that is true, he begins attacking the player
        if (distanceToPlayer <= 13 && distanceToPlayer > agent.stoppingDistance / 3)
        {
            Debug.Log("Ranged : Engage Combat!");
        }
        //Checks whether the Player is too close, if that is true, he begins moving away from the Player
        else if(distanceToPlayer <= agent.stoppingDistance/3)
        {
            Debug.Log("weg hier!");
           
        }

    }

    public override void combatBehaviour()
    {

        Debug.Log("filler");

    }
}
