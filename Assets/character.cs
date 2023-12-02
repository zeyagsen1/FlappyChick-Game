using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public GameObject bulletinstance;
    public float time=0;
      public GameObject bullet;
    public string direction;
    public float minY = -2f; // Minimum Y position
    public float maxY = 2f; // Maximum Y position
    public float moveSpeed = 1f;

     void Start()
    {
        direction="up";
    }

    // Update is called once per frame
    void Update()
    {
       float newY = Mathf.Sin(Time.time * moveSpeed) * (maxY - minY) / 2f + (maxY + minY) / 2f;
        
        // Update the character's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

         /*   if(time>2){
         bulletinstance=Instantiate(bullet,new Vector3(transform.position.x,newY,0),transform.rotation);
         
         time=0;
        
        }
       else{

        time+=Time.deltaTime;
       }
*/
       

        }
    }

