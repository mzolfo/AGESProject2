using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour 
{
    GameObject Player;
    GameObject Spawner;

    Vector3 playerLoc;
    ObstacleSpawner spawnerScript;
    bool pastpoint = false;
    private void Awake()
    {
        Player = GameObject.Find("PlayerStar");
        Spawner = GameObject.Find("Spawner");
    }
    // Use this for initialization
    void Start () 
	{
        playerLoc = Player.GetComponent<Transform>().position;
        spawnerScript = Spawner.GetComponent<ObstacleSpawner>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        this.gameObject.transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        if (CheckPositionTooFarBehind())
        {
            if (!pastpoint)
            {
                spawnerScript.starsSpawned = spawnerScript.starsSpawned - 1;
                pastpoint = true;
            }
            
        }
        else { pastpoint = false; }
        
	}

    bool CheckPositionTooFarBehind()
    {
        if (this.gameObject.transform.position.x < playerLoc.x - 16) //this a magic number, bind to variable?
        {
            return true;
        }
        else { return false; }
    }
}
