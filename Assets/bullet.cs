using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class bullet : MonoBehaviour
{
    public float deadZone=-40;
    public float moveSpeed=1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        this.transform.position=transform.position+(Vector3.left*moveSpeed)*Time.deltaTime;
        
        if(transform.position.x<-4){
            Destroy(gameObject);
        }
        
    }
}
