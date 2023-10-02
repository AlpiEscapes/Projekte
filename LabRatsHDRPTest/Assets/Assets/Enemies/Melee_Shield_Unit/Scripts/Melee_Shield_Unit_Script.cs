using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Melee_Shield_Unit_Script : BaseEnemy
{
    private NavMeshAgent agent;
    private float distanceToPlayer;
    private bool shield =true;
    private float timeRemaining = 3;


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

        
        distanceToPlayer = Vector3.Distance(Player.transform.position, this.transform.position);

        //Checks whether the Player is in Aggro Range, if that is true, he chases the Player
        if (distanceToPlayer >= agent.stoppingDistance && distanceToPlayer <= 25)
        {
            Debug.Log("Melee : Move Towards Player!");
            agent.SetDestination(base.Player.transform.position);
            
        }

        //Checks whether the Player is in Combat Range, if that is true, he begins attacking the player
        if (distanceToPlayer <= agent.stoppingDistance   )
        {
            Debug.Log("Melee : Engage Combat!");
            combatBehaviour();
        }
    }
    // What does the enemy Melee Unit do without a shield? 
    //Enemy Unit will decide between shieldbashing (which stuns the Player) and having a defensive state which allows him to deflect enemy attacks
    public override void combatBehaviour()
    {

        // Rotate to player 
        //this.transform.LookAt(Player.transform);

        if (shield)
        {             
            Debug.Log("Countdown: " + timeRemaining);
            timeRemaining -= Time.deltaTime;
                


            if (timeRemaining <= 0)
            {
                int randomAct = Random.Range(0, 1);

                if(randomAct == 1)
                {                 
                    shieldBash();
                }
                else
                {
                    shieldReflect();
                }
            }        
        }
        else
        {
            shieldlessAttack();
        }
    
    }

    public void shieldlessAttack()
    {
        //An Attack without the shield which didn't get defined yet
        timeRemaining = 3;
    }

    public void shieldBash()
    {
        //An Attack without the shield which didn't get defined yet
        timeRemaining = 3;
    }

    public void shieldReflect()
    {
        //An Attack without the shield which didn't get defined yet
        timeRemaining = 3;
    }
}
