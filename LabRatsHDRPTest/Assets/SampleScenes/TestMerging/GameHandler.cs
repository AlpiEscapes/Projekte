using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    //if this is enabled debug messages will show, turn this of in production version
    public static readonly bool DEBUG_MODE = true;

    private PlayerStats player;
    private Animator anim;
    private GameObject[] healSlots = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(GameObject.FindGameObjectWithTag("HealSlots").transform.GetChild(1).name);
        for (int i = 0; i < GameObject.FindGameObjectWithTag("HealSlots").transform.childCount; i++)
        {
            healSlots[i] = GameObject.FindGameObjectWithTag("HealSlots").transform.GetChild(i).gameObject;
        }

        foreach (GameObject item in healSlots)
        {
            item.SetActive(false);
        }
        player = GameObject.FindGameObjectWithTag("PlayerHolder").GetComponent<PlayerStats>();
        CurrentLevelData.CheckpointCoords = new float[3] { player.gameObject.transform.position.x, player.gameObject.transform.position.y, player.gameObject.transform.position.z };
        anim = player.gameObject.GetComponent<Animator>();
        LoadGame();
    }

    // Update is called once per frame
    void Update()
    {
        //Wird alles vom Collisionobject getriggered wenn fertig
        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayerDamage(player.DamageValue);
        }
        if (Input.GetKeyDown(GameManager.GM.heal) && player.HealItemAmount > 0 && player.CurrentHealth < player.MaxHealth)
        {
            anim.SetBool("isPunching", true); //Punching temporary (isHealing)
            anim.Play("Heal");
        }
    }


 

    //triggered upon receiving damage
    public void PlayerDamage(int damageValue)
    {
        //updates playerstats
        player.TakeDamage(damageValue);
        //updates HP bar sprite
        player.UpdateHpBar();
    }
    //triggered upon using health item
    public void PlayerHeal(int healValue)
    {
        //updates playerstats
        player.Heal(healValue);
        //updates HP bar sprite
        player.UpdateHpBar();

        UpdateHPItemsUI();

    }
    public void UpdateHPItemsUI()
    {
        switch (player.HealItemAmount)
        {
            case 0:
                foreach (GameObject item in healSlots)
                {
                    item.SetActive(false);
                }
                break;
            case 1:
                healSlots[0].SetActive(false);
                healSlots[1].SetActive(false);
                healSlots[2].SetActive(true);
                break;
            case 2:
                healSlots[0].SetActive(false);
                healSlots[1].SetActive(true);
                healSlots[2].SetActive(true);
                break;
            case 3:
                healSlots[0].SetActive(true);
                healSlots[1].SetActive(true);
                healSlots[2].SetActive(true);
                break;
        }
    }

    //Triggered upon clicking checkpoint device
    public void SetPlayerCheckPoint()
    {
        CurrentLevelData.CheckpointCoords = new float[3]{ player.gameObject.transform.position.x, player.gameObject.transform.position.y, player.gameObject.transform.position.z}; 
    }

    //
    public void LoadPlayerCheckPoint()
    {
        //Teleport to checkpoint
        Debug.Log(CurrentLevelData.CheckpointCoords[0] + " " + CurrentLevelData.CheckpointCoords[1] + " " + CurrentLevelData.CheckpointCoords[2]);
        player.gameObject.transform.position = new Vector3(CurrentLevelData.CheckpointCoords[0], CurrentLevelData.CheckpointCoords[1], CurrentLevelData.CheckpointCoords[2]);
        
    }

    //triggered upon clicking checkpoint
    public void SaveGame()
    {
        SetPlayerCheckPoint();
        SaveData saveData = new SaveData(player.CurrentHealth, CurrentLevelData.CheckpointCoords, CurrentLevelData.Id);
        saveData.ToString();
        SaveManager.SaveGame(saveData);
    }


    //Loads savegame into game
    public void LoadGame()
    {
        SaveData data = SaveManager.LoadData();
        CurrentLevelData.Id = data.id;
        player.CurrentHealth = data.health;
        Debug.Log(data.checkpointCoords[0]);
        CurrentLevelData.CheckpointCoords = data.checkpointCoords;
        player.UpdateHpBar();
        data.ToString();
        LoadPlayerCheckPoint();

    }
}
