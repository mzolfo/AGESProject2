using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        this.gameObject.transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
	}
}
