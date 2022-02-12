using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    void Start()
    {
        
    }

   
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement(){

        float xVal = Input.GetAxis("Horizontal")  * Time.deltaTime * moveSpeed;
        float yVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xVal,0,yVal);

    }
}
