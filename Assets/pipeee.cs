using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeee : MonoBehaviour
{
 
    public float moveSpeed=1;  
    public int deadZone=-4;
 public BoxCollider2D b;
 

    void Start()
    {
        
    }

 
    void Update()
    {
        this.transform.position=transform.position+(Vector3.left*moveSpeed)*Time.deltaTime;
        if(transform.position.x<deadZone){
            Destroy(gameObject);
        }
    }
}
