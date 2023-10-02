using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The attackManager will be used for the Combo inputs
//Combos are chained attacks
//Animations will have to be played in the correct order
public class AttackManager : MonoBehaviour
{
    //the animator of the character which will be used to play the animations
    //The hitboxes of the character model will hit the hurtboxes of enemies and apply damage to them
    private Animator playerAnim;
    //if it is possible to execute combo
    private bool comboPossible;
    //the current step of the combo
    int comboStep;

    //Attack
    public void Attack()
    {
        //If it is the first stage of the combo play first anim and set step to 1
        if(comboStep == 0)
        {
            playerAnim.SetBool("isPunching", true);
            playerAnim.Play("Boxing");
            comboStep = 1;
            return;
        }
        //if combo is possible and the step is not the first one add a step and disable combo
        if(comboStep != 0 && comboPossible)
        {
            comboPossible = false;
            comboStep += 1;
        }
    }

    //Set the combo possible
    public void ComboPossible()
    {
        comboPossible = true;
    }
    //Play the currently selected animation
    public void Combo()
    {
        switch (comboStep)
        {

            case 2: playerAnim.Play("Punching Bag"); playerAnim.SetBool("isPunching", true); 
                break;
            case 3: playerAnim.Play("Elbow Punch"); playerAnim.SetBool("isPunching", true);
                break;

        }
    }

    //Reset the combo counter to 0 (After attack or last combo attack)
    public void ComboReset()
    {
        playerAnim.SetBool("isPunching", false);
        comboPossible = false;
        comboStep = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if attack button 1 is pressed play a punching animation
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && !(GameObject.FindGameObjectWithTag("UI_Cooldown").transform.GetChild(4).gameObject.activeSelf))
        {
            playerAnim.Play("SpecialAttack1");
            GameObject.FindGameObjectWithTag("UI_Cooldown").GetComponent<Abilities>().ChangeAbilities(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && !(GameObject.FindGameObjectWithTag("UI_Cooldown").transform.GetChild(3).gameObject.activeSelf))
        {
            playerAnim.Play("SpecialAttack2");
            GameObject.FindGameObjectWithTag("UI_Cooldown").GetComponent<Abilities>().ChangeAbilities(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && !(GameObject.FindGameObjectWithTag("UI_Cooldown").transform.GetChild(2).gameObject.activeSelf))
        {
            playerAnim.Play("SpecialAttack3");
            GameObject.FindGameObjectWithTag("UI_Cooldown").GetComponent<Abilities>().ChangeAbilities(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && !(GameObject.FindGameObjectWithTag("UI_Cooldown").transform.GetChild(1).gameObject.activeSelf))
        {
            playerAnim.Play("SpecialAttack4");
            GameObject.FindGameObjectWithTag("UI_Cooldown").GetComponent<Abilities>().ChangeAbilities(1);
        }
    }
}
