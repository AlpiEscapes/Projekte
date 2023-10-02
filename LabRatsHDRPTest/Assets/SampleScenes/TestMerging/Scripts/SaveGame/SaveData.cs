using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Contains all data which are to be saved to a file
[System.Serializable]
public class SaveData
{
    //Inventory
    //Story progress
    //Map state
    public int health;
    public float[] checkpointCoords;
    public int id;

    public SaveData(int health, float[] checkpointCoords, int id/*,inventory, story progress, map state*/)
    {
        this.health = health;
        this.checkpointCoords = checkpointCoords;
        this.id = id;

        /*inventory*/
        /*story progress*/
        /*map state*/
    }

    public override string ToString()
    {
        return "health: " + health + " coords: x:" + checkpointCoords[0] + " y: " + checkpointCoords[1] + " z: " + checkpointCoords[2];
    }
}
