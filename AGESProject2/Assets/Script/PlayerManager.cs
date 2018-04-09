using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {



    

    
    int storedWaveRate = 40;
    int CurrentWaveRate = 0;
    public int deadplayers = 0;

    [SerializeField]
    int wave = 1;
    [SerializeField]
    int waveEnemies = 20;
    int nextWaveEnemies = 45;

    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    [SerializeField]
    float TargetedDist = 0f;
    [SerializeField]
    GameObject trgetedPlayer;
    [SerializeField]
    int chosenspawn;

   

private void Awake() //if you need this script to find things do it in awake
    {
        
     }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
	}

    private void FixedUpdate()
    {
            if (wave < 8)
            {
                if (waveEnemies >= 1)
                {
                    if (CurrentWaveRate == 0)
                    {
                        Spawn();
                        waveEnemies = waveEnemies - 1;
                        CurrentWaveRate = storedWaveRate;
                    }
                    else { CurrentWaveRate = CurrentWaveRate - 1; }
                }
                else if (waveEnemies == 0)
                {
                    UpdateWaveRate();
                }
            }
    }

    void UpdateWaveRate()
    {
        if (wave <= 8)
        {
            wave = wave + 1;
            storedWaveRate = storedWaveRate - 5;
            waveEnemies = nextWaveEnemies;
            nextWaveEnemies = nextWaveEnemies + 15;
           
        }
        
    }
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        chosenspawn = spawnPointIndex;
    
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        EnemyMovement spawnedScript = enemy.GetComponent<EnemyMovement>();
        

    }
    
}


//ok what now is left

   

    //nothing indicates to the player that the game has begun/that they can join and that the game has begun and that the players can no longer join.

    //