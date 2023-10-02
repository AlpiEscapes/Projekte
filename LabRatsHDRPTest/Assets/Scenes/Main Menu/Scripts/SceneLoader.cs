using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadOptionsScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadExtrasScene()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadDifficultyScene()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadLoadingScene()
    {
        SceneManager.LoadScene(4);
        
    }

    public void LoadKeybindsScene()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadGameTestScene()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadGameScene()
    {
        Dropdown dropdown = GameObject.FindGameObjectWithTag("SelectSaveGame").GetComponent<Dropdown>();
        if (dropdown.options[dropdown.value].text != "")
        {
            CurrentLevelData.NewGame = false;
            CurrentLevelData.Id = int.Parse(dropdown.options[dropdown.value].text.Substring(dropdown.options[dropdown.value].text.Length-1, 1));
            SceneManager.LoadScene(6);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}