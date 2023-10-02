using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public GameObject text;
    private bool inRange;


    //Gets triggered if player is in range of coke dispenser and displays the interactable text
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            inRange = true;
            
            text.SetActive(true);
        }
    }

    //Removes the text when going out of range of the coke dispenser
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            inRange = false;
            if (text.activeSelf)
            {
                text.SetActive(false);
            }
        }
    }

    private void Update()
    {
        //Pressing E with the coke coin in inventory opens the final exit + plays sound + sets hp + hydration to full and updates the HUD properly
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameHandler>().SetPlayerCheckPoint();
            GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameHandler>().SaveGame();
            Debug.Log("Game Saved");
        }
    }
}
