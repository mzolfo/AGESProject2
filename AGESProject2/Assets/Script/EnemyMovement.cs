using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    

    

    public GameObject TargetPlayer;
    

    int hasHit;
    Transform target;
    public float ownHealth = 30f;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake()
    {
        target = TargetPlayer.transform;
        
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    void Update()
    {

        if (ownHealth <= 0)
        { Destroy(gameObject); }

        if (Vector3.Distance(transform.position, target.position) < 3f)
        {
            nav.enabled = false;
            if (hasHit == 0)
            {
              
                hasHit = 100;
            }
            else
            { hasHit = hasHit - 1; }
        }
        else {
            nav.enabled = true;
            nav.SetDestination(target.position);
        }

        if (hasHit != 0)
        { hasHit = hasHit - 1; }
        
    }

   

    

}





























    //  IEnumerator HitEffect()
    // {

    //     while (MyColor.color != stateColor)
    //    {

    //       Color LerpingColor = Color.Lerp(hitColor, stateColor, 100f * Time.deltaTime);
    //    whatsbeinglerpedthen = LerpingColor;
    //     MyColor.color = LerpingColor;
    //     yield return null;
    //  }



    // Color hitColor = new Color(1f, 0f, 0f, 1f);
    //Color stateColor = new Color(1f, 0.5f, 0.063f, 1f);

    // }