using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kedi : MonoBehaviour
{
    public float moveSpeed=1;
   

    public float deadZone=-4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         this.transform.position=transform.position+(Vector3.left*moveSpeed)*Time.deltaTime;
        if(transform.position.x<deadZone){
            Destroy(gameObject);
        }
    }
}
