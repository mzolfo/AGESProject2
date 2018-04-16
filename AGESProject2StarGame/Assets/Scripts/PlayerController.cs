using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{

    public enum PlayerPosition { Top, Center, Bottom };
    public PlayerPosition where;

    public int top = 2;
    public int center = 0;
    public int bottom = -2;

    public float speed = 5;
   

   
    private int lasttag = 0;

   


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
                //this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Mathf.Lerp(this.gameObject.transform.position.y, bottom, Time.deltaTime));
            }
            else
            {
                where = PlayerPosition.Top;
                //this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Mathf.Lerp(this.gameObject.transform.position.y, top, Time.deltaTime));
            }
        }
    }

    void Move()
    {
        /*transform.Translate(Vector3.right * Time.deltaTime * speed); */
        //for whatever reason the above string gave a very bizzare glitch, the player would sit in place and drift slowly backwards
        
        if (where == PlayerPosition.Top)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Mathf.Lerp(this.gameObject.transform.position.y, top, Time.deltaTime * 2));
        }

        else
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Mathf.Lerp(this.gameObject.transform.position.y, bottom, Time.deltaTime * 2));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Collision Works
        Destroy(this.gameObject);
    }

    
}
