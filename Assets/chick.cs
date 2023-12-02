using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chick : MonoBehaviour
{
   // public SpriteRenderer targetSize;
   public AudioSource jumpAudio;
      public AudioSource gameMusic;

   public kedi kedi;
     public bool isAlive=true;
    public float flapStrength;
    public Rigidbody2D ds; 
    public logic l;
     void Start()
    {
       // gameMusic.Play();
        /*
         l=GameObject.FindGameObjectWithTag("Logic").GetComponent<logic>();

         float screenRatio=(float)Screen.width/(float)Screen.height;
         float targetRatio=targetSize.bounds.size.x/targetSize.bounds.size.y;
         if(screenRatio>=targetRatio){

            Camera.main.orthographicSize=targetSize.bounds.size.y/2;
         }
         else{
            float differenceInSize=targetRatio/screenRatio;
            Camera.main.orthographicSize=targetSize.bounds.size.y/2*differenceInSize;
         }

        */
    }

    // Update is called once per frame
    void Update()
    {
       
     
    if (Input.GetKeyDown(KeyCode.Space) == true&&isAlive==true)
        {
            ds.velocity = Vector2.up * flapStrength;
            jumpAudio.Play();
        }
        









        if(transform.position.y>2.43||transform.position.y<-2.43){

            l.gameOver();
            isAlive=false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
      if(collision.gameObject.CompareTag("top")||collision.gameObject.CompareTag("bottom")){
      isAlive=false;
      l.gameOver();
      
    }
    if(collision.gameObject.CompareTag("mermi")){

        isAlive=false;
        l.gameOver();
    }
    
    

  

    
    



    }
         void OnTriggerEnter2D(Collider2D other)
    {
       if(other.CompareTag("kedii")){
        Destroy(other.gameObject);
        l.addScore();
       }
    
    }




}

