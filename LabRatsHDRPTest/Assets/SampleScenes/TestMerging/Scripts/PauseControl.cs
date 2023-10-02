using UnityEngine;

public class PauseControl : MonoBehaviour
{

    public static bool gameIsPaused; //Holds the current state. If true the game is paused else its running. Can be accessed globally
    private GameObject escMenu;
    private GameObject inventory;

    private GameObject[] ingame_ui;



    void Start()
    {
        //initialize escmenu
        escMenu = GameObject.FindGameObjectWithTag("EscMenu");
        escMenu.SetActive(false);

        inventory = GameObject.FindGameObjectWithTag("Inventory");
        inventory.SetActive(false);

        ingame_ui = GameObject.FindGameObjectsWithTag("UI_Ingame");

       

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //If the OpenMenu button is pressed 
        {
            PauseOrResumeGame(); //Calls the pausgame function
        }
    }

    public void PauseOrResumeGame() //Pauses the game via the timescale (this can be used for almost all physic.) IF animations/Physic should be applied during pause refer to this guide: https://gamedevbeginner.com/the-right-way-to-pause-the-game-in-unity/
    {
        if (gameIsPaused) //If the game is paused
        {
            PauseGame(); //Calls the pauseGame function
        }
        else
        {
            ResumeGame(); //Calls the resumeGame function
        }
        gameIsPaused = !gameIsPaused; //Sets the current state to the opposite state
    }

    public void PauseGame()
    {
        Time.timeScale = 0f; //sets the timescale to 0 which stops all physic/animation
        escMenu.SetActive(true);
        inventory.SetActive(true);

        foreach (GameObject item in ingame_ui)
        {
            item.SetActive(false);
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1; //sets the timescale to 1 which continues all physics/animation
        escMenu.SetActive(false);
        inventory.SetActive(false);

        foreach (GameObject item in ingame_ui)
        {
            item.SetActive(true);
        }
    }

    public void PauseAudio()
    {
        AudioListener.pause = true; //Pauses all audio
    }

    public void ResumeAudio()
    {
        AudioListener.pause = false; //Resumes all audio
    }









}
