using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int score = 0;



  private void OnCollisionEnter(Collision other){

      if(other.gameObject.tag != "AlreadyHit"){
        score++;
      Debug.Log(score);
      }
     
  }
      
  
}
    
    
    
    
