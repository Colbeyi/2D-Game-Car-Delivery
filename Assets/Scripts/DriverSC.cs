using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverSC : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 200f;
    [SerializeField] float forwardSpeed = 0.01f;
    
    


    void Update()
    {
        float rotationHorizontal = Input.GetAxis("Horizontal"); 
        float forwardAccel = Input.GetAxis("Vertical");
        transform.Rotate(0,0,-rotationHorizontal*rotationSpeed*Time.deltaTime);
        transform.Translate(0, forwardAccel*forwardSpeed*Time.deltaTime, 0);




    }
   


}

