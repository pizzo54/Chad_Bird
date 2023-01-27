using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pipe;
    public float TimeB = 2;
    private float  start = 0 ;
    public float Distance = 8 ;
    void Start()
    {
        pipeappear();
    }
    void Update()
    {  if (start < TimeB)
        {
            start = start + Time.deltaTime;
        }
        else {
            pipeappear(); 
            start = 0 ;
        }   
    }
    void pipeappear()
    {
        float maxapp = transform.position.y + Distance;
        float minapp = transform.position.y - Distance;
        
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(minapp,maxapp),transform.position.z), transform.rotation);
    }
}
