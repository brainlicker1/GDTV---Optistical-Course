using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTimer : MonoBehaviour
{ 
    
    [SerializeField] float  dropTime = 1f;
    
       void Update()
    {
        Timer();
    }

    void Timer(){

       var gTimer = Time.time;
       if(gTimer > dropTime )  {

           Debug.Log("5 seconds");

       }
       

    }
}
