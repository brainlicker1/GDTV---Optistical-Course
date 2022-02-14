using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int score = 0;



  private void OnCollisionEnter(Collision other){


      score++;
      Debug.Log(score);
  }
      
  
}
    
    
    
    
