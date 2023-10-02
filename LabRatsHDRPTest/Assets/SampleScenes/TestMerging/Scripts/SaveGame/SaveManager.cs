using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

//Saves the relevant game data to a file
public class SaveManager
{
    private readonly static string SAVEGAME_NAME = "/LabRats";
    public static void SaveGame(SaveData data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + SAVEGAME_NAME + data.id;
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    //Load the relevant game data from a file if it exists
    public static SaveData LoadData()
    {
        

        string path = Application.persistentDataPath + SAVEGAME_NAME + CurrentLevelData.Id;
        Debug.Log(path);
        if (!CurrentLevelData.NewGame)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData data = formatter.Deserialize(stream) as SaveData;
            stream.Close();

            return data;
        }
        else
        {
            //get highest file id
            string[] files = Directory.GetFiles(Application.persistentDataPath + "/");
            int maxId = 0;
            foreach (string file in files)
            {
                if (int.Parse(file.Substring(file.Length - 1, 1)) >= maxId)
                {
                    maxId = int.Parse(file.Substring(file.Length - 1, 1)) + 1;
                }
            }
            //Creates new SaveData for new game
            SaveData data = new SaveData(100, CurrentLevelData.CheckpointCoords, maxId);
            
            SaveGame(data);

            return data;
        }
    }
}
