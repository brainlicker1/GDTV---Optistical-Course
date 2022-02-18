using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{  

    
    private void OnCollisionEnter(Collision other){

        if(other.gameObject.tag == "Player"){
  
            Debug.Log("Eat Shit Cubeguy");
        GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "AlreadyHit";
        }
        
        

    }
     

   


    
}
