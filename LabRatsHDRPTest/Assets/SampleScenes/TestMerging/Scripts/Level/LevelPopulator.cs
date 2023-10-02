using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LevelPopulator : MonoBehaviour
{
    //enemy types that can spawn
    public GameObject rangedEnemy;
    public GameObject meleeEnemy;

    //Items that can spawn
    public GameObject healItem;

    //Navmesh for the corresponding level
    public NavMeshData navmeshCurrent;


    // Start is called before the first frame update
    void Start()
    {
        //Contains all item spawn locations of the map
        GameObject[] itemLocations = GameObject.FindGameObjectsWithTag("ItemSpawnPos");

        //Contains all Enemy spawn locations of the map
        GameObject[] enemyLocations = GameObject.FindGameObjectsWithTag("EnemySpawnPos");

        //Alle items instanziieren
        foreach (GameObject item in itemLocations)
        {
            if (item.name.Contains("Heal"))
            {
                Instantiate(healItem, item.transform);
            }            
        }

        //Alle gegner instanziieren
        foreach (GameObject item in enemyLocations)
        {
            GameObject enemy;
            if (Random.Range(0, 100) < 75)
            {
                enemy = Instantiate(meleeEnemy, item.transform);
            }
            else
            {
                enemy = Instantiate(rangedEnemy, item.transform);
            }
            enemy.GetComponent<BehaviorExecutor>().SetBehaviorParam("player", GameObject.FindGameObjectWithTag("PlayerHolder"));
            enemy.GetComponent<BehaviorExecutor>().SetBehaviorParam("area", navmeshCurrent);
            enemy.GetComponent<BehaviorExecutor>().SetBehaviorParam("enemy", enemy);
            enemy.GetComponent<BehaviorExecutor>().SetBehaviorParam("targetPosition", GameObject.FindGameObjectWithTag("PlayerHolder"));
        }
    }
}
