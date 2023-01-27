using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PipeS : MonoBehaviour
{
    public float movespeed ;
    public float maxx = - 34 ;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ( Vector3.left * movespeed ) * Time.deltaTime ;

        if(transform.position.x < maxx)
        {
            Destroy(gameObject);
            Debug.Log("succesfuly");
        }
    }
  
}
