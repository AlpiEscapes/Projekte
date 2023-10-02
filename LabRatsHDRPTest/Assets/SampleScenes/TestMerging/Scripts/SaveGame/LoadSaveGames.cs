using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadSaveGames : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown dropdown = GameObject.FindGameObjectWithTag("SelectSaveGame").GetComponent<Dropdown>();

        string[] files = Directory.GetFiles(Application.persistentDataPath + "/");
        for (int i = 0; i < files.Length; i++)
        {
            files[i] = files[i].Substring(files[i].LastIndexOf('/')+1);
        }

        List<string> someList = new List<string>(files);
        dropdown.AddOptions(someList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
