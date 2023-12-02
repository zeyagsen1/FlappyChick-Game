
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class logic : MonoBehaviour
{    
    public AudioSource eatCat ;

    public AudioSource deathAudio ;
    public float catScore=0;
    public GameObject g;
    public Text scoreText;
    public int score=0;
    public Text cattt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
     

        
    
        
    }
    [ContextMenu("Increase the Score")]
     public void addScore(){
      
      score+=1;
      scoreText.text= score.ToString();
      eatCat.Play();

    }
    public void addCatScore(){

        catScore+=1;
        cattt.text=   "Cat Score:"+  catScore;

    }

    public void gameOver(){
      
        g.SetActive(true);
       
        
 
}

public void restart(){

    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

}
