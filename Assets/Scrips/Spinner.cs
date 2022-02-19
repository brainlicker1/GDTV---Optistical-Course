using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
  
    [SerializeField] float xAxisSpeed = 0;
    [SerializeField] float yAxisSpeed = 1;
    [SerializeField] float zAxisSpeed = 0;
    
    void Update()
    {
        RotateThing();
    }

    void RotateThing(){
        transform.Rotate(xAxisSpeed, yAxisSpeed,zAxisSpeed);
    }
}
