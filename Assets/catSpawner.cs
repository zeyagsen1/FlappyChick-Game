using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catSpawner : MonoBehaviour
{
    public float  time=0;
    public GameObject g;
  
    void Start()
    {
        
    }

    void Update()
    {
        
        
        if(time>2){
       
        Instantiate(g, new Vector3(transform.position.x, Random.Range(0, 2), 0), transform.rotation);
        time=0;

        }

        else{

         time+=Time.deltaTime;
        }
        
    }
}
