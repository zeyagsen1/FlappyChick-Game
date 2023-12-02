using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
 public float moveSpeed=25;  
 public BoxCollider2D b;
 

    void Start()
    {
        
    }

 
    void Update()
    {
        this.transform.position=transform.position+(Vector3.left*moveSpeed)*Time.deltaTime;
    }
}
