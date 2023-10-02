using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //forces the gameobject to have the AudioSource Component
public class TonbandScript : MonoBehaviour
{
    private AudioSource audio;
    public bool hasPlayed = false; //defines if the picked up object already played its sound (needed so it only gets destroyed after it has played)

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    public void PlaySound() //Gets called on pickup
    {
        audio.Play(0); //Plays the sound which is refernced by the audiosource component
        hasPlayed = true; //Defines that its sound has been played

        //Destroyes the children which make up the visual part of the tape
        Destroy(transform.GetChild(0).gameObject); 
        Destroy(transform.GetChild(1).gameObject);
    }

    private void Update()
    {
        if (!audio.isPlaying && hasPlayed) //Checks if the audioSource is still playing its sound and if the sound was already played once
        {
            Destroy(gameObject);
        }

    }
}
