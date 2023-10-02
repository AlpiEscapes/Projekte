using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_hit : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (transform.parent.parent.gameObject.tag.Equals("PlayerHolder"))
        {
            //Debug.Log("HIT");
            other.GetComponent<StatSystem>().TakeDamage(50);
        }
        else 
        {
            if (other.gameObject.tag.Equals("PlayerHolder"))
            {
                Debug.Log("HIT");
                GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameHandler>().PlayerDamage(5);
            }          
        }
        
    }
}
