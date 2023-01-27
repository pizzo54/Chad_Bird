using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public levelup l;
    void Start()
    {
        l = GameObject.FindGameObjectWithTag("block").GetComponent<levelup>();
      
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        l.addlevel();
    }
}
