using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle : MonoBehaviour
{
    logic l;
    // Start is called before the first frame update
    void Start()
    {
        l=GameObject.FindGameObjectWithTag("Logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        

        
    } 

    private void OnTriggerEnter2D(Collider2D collison){

     l.addScore();
    }
    
}
