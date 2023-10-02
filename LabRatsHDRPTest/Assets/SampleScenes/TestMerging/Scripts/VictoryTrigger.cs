using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryTrigger : MonoBehaviour
{
    public GameObject victoryScreen;


    //Gets triggered if player is in range of coke dispenser and displays the interactable text
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "VictoryPoint")
        {


            victoryScreen.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
