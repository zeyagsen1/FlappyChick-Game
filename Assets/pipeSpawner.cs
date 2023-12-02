using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public float t=0;
   
   
    public GameObject gameobject;
    void Start()
    {
   create();
    }

    // Update is called once per frame
    void Update()
    {

        
        if(t>2){
            create();
         t=0;
        }
         
         else{
            t+=Time.deltaTime;

         }

    }

    void create(){
        
       // Instantiate(gameobject,transform.position,transform.rotation);
         float low=transform.position.y-15;
         float high=transform.position.x+15;
         
        Instantiate(gameobject, new Vector3(transform.position.x, Random.Range(0, 2), 0), transform.rotation);

    }
}
