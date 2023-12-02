using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    //public float flapStrength;
    public Rigidbody2D ds; 
    public bool isAlive=true;
     void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
        if (Input.GetKeyDown(KeyCode.Space) == true&&isAlive)
        {
            ds.velocity = Vector2.up * 150*Time.deltaTime;
        }
    }
}
