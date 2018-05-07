using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObstacleSpawner : MonoBehaviour {

    ObjectPooler objectPooler;
    public int totalStarsSpawned = 0;
    public int starsSpawned = 0;
    public int timeTillNextSpawn = 150;
    public int timer = 300;
    int score = 0;

    public PlayerController Player;

    public Text scoreText;
    public Text instructText;
    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    private void Update()
    {
        if (!Player.deathstate)
        { score = totalStarsSpawned; }
        else
        { instructText.text = "You have collided, your final score was: " + score + "\nPress Escape to return to the main menu"; }
        
         scoreText.text = "Score: " + score;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        
    }

    private void FixedUpdate()
    {
        if (starsSpawned < 17)
        {
            if (timer <= 0)
            {
                objectPooler.SpawnFromPool("O", CreateNewYPosition(), Quaternion.identity);
                starsSpawned++;
                totalStarsSpawned++;
                timer = timeTillNextSpawn;
            }
        }
        timer--;
        setSpawnFrequency();

    }

    private Vector3 CreateNewYPosition()
    {
        int coinflip;
        coinflip = Random.Range(1, 3);
        if (coinflip < 2)
        {
            Vector3 newVal = new Vector3(this.gameObject.transform.position.x, 2f, this.gameObject.transform.position.z);
            return newVal;
        }
        else
        {
            Vector3 newVal = new Vector3(this.gameObject.transform.position.x, -2f, this.gameObject.transform.position.z);
            return newVal;
        }

        
    }


    void setSpawnFrequency()
    {
        if (totalStarsSpawned >= 15 && totalStarsSpawned < 30)
        {
            timeTillNextSpawn = 125;
        }
        else if (totalStarsSpawned >= 30 && totalStarsSpawned < 45)
        {
            timeTillNextSpawn = 100;
        }
        else if (totalStarsSpawned >= 45 && totalStarsSpawned < 60)
        {
            timeTillNextSpawn = 75;
        }
        else if (totalStarsSpawned >= 60 && totalStarsSpawned < 85)
        {
            timeTillNextSpawn = 50;
        }
        else if (totalStarsSpawned >= 85 && totalStarsSpawned < 100)
        {
            timeTillNextSpawn = 40;
        }
        else if (totalStarsSpawned >= 100 && totalStarsSpawned < 130)
        {
            timeTillNextSpawn = 35;
        }
        else if (totalStarsSpawned >= 130 && totalStarsSpawned < 150)
        {
            timeTillNextSpawn = 30;
        }
        else if (totalStarsSpawned >= 150 && totalStarsSpawned < 200)
        {
            timeTillNextSpawn = 25;
        }
        else if (totalStarsSpawned >= 200 && totalStarsSpawned < 250)
        {
            timeTillNextSpawn = 20;
        }
        else if (totalStarsSpawned >= 250 && totalStarsSpawned < 300)
        {
            timeTillNextSpawn = 15;
        }
    }
    
}
