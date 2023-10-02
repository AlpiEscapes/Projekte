using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //forces the gameobject to have the AudioSource Component
public class SoundHolder : MonoBehaviour
{
    private AudioSource audio; //Stores the audio source which plays the clips
    private Dictionary<string,AudioClip> audioClipsDict; //Stores the audioclips in key value pairs (name,clip)
    public List<string> audioNames; //Temporarily stores the audio names because dictionaries are not exposed to the inspector
    public List<AudioClip> audioClips; //Temporarily stores the audio clips because dictionaries are not exposed to the inspector

    private void Start()
    {
        if (audioNames.Count != audioClips.Count) //When one of the lists has more objects than the other an exception is thrown to warn the user
        {
            throw new System.Exception("Both lists need to be the same length!");
        }

        audio = GetComponent<AudioSource>(); //gets the audio source from the object
        for (int i = 0; i < audioNames.Count; i++) //Assigns all name, clip key value pairs to the dictionary
        {
            audioClipsDict[audioNames[i]] = audioClips[i];
        }
    }

    public void PlayAudio(string audioName)
    {
        audio.PlayOneShot(audioClipsDict[audioName]); //Plays the audio clip with the given name
    }
}
