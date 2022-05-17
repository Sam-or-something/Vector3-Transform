using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Vector3 movementSpeed;

    void Update()
    {
        //transform.position += movementSpeed;
        if (transform.position.x < 10){
            transform.position += movementSpeed;
        } 
    }
}
