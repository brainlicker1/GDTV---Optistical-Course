using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTimer : MonoBehaviour
{ 
    
    [SerializeField] float  dropTime = 1f;
    Rigidbody rb;
    MeshRenderer mRender;

     void Awake() {
        rb = GetComponent<Rigidbody>();
        mRender = GetComponent<MeshRenderer>();
    }
     void Start()
    {   
        mRender.enabled = false;
        rb.useGravity = false;
    }
       void Update()
    {
        Timer();
    }

    void Timer(){

       var gTimer = Time.time;
       if(gTimer > dropTime )  {
           mRender.enabled = true;
           rb.useGravity = true;
           

       }
       

    }
}
