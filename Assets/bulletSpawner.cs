using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    public GameObject character;
   public float time=0;
    public GameObject bullet;
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time>4){

         Instantiate(bullet,new Vector3(transform.position.x,character.transform.position.y,0),transform.rotation);
         time=0;
        }
       else{

        time+=Time.deltaTime;
       }
       
    }
    
    
}
