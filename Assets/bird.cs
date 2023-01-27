using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public Rigidbody2D birdy;
    public float speed;
    public GameObject scene;
    public bool birsalive = true;
    void Start()
    {
        gameObject.name = "bird chhwani";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birsalive )
        {
            birdy.velocity = Vector2.up * speed ;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        birsalive = false;
        scene.SetActive(true);
    }
}
