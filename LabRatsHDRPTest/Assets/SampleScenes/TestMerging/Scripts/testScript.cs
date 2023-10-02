using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    // Start is called before the first frame update

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PlayerStats stats = GameObject.FindGameObjectWithTag("PlayerHolder").GetComponent<PlayerStats>();
            Transform t  = GameObject.FindGameObjectWithTag("PlayerHolder").transform;
            float[] coords = { t.position.x, t.position.y, t.position.z };
            
            //SaveManager.SaveGame(stats.CurrentHealth, coords);
            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log(SaveManager.LoadData(CurrentLevelData.Id));
        }
    }

}

