using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{

    public enum PlayerPosition { Top, Center, Bottom };
    public PlayerPosition where;

    

    public int top = 2;
    public int center = 0;
    public int bottom = -2;

    public float speed = 5;

    public Text instructText;
    int instructed = 0;

    public bool deathstate = false;
    
    // Update is called once per frame
    void Update()
    {
        if (!deathstate)
        {
            if (instructed == 3)
            {
                instructText.text = "";
            }
            else if (instructed <= 3)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    instructed++;
                }
            }
        }
       
       
        ChangeLane();
        Move();
    }

    void ChangeLane()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            if (where == PlayerPosition.Top)
            {
                where = PlayerPosition.Bottom;
                
            }
            else
            {
                where = PlayerPosition.Top;
                
            }
        }
    }

    void Move()
    {
       
        if (where == PlayerPosition.Top)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Mathf.Lerp(this.gameObject.transform.position.y, top, Time.deltaTime * 2));
        }

        else
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Mathf.Lerp(this.gameObject.transform.position.y, bottom, Time.deltaTime * 2));
        }
    }

   
    private void OnTriggerEnter(Collider other)
    {
        deathstate = true;
        this.gameObject.SetActive(false);
    }

}
