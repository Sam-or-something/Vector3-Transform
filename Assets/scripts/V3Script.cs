using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V3Script : MonoBehaviour
{
    public Vector3 miVector;
    public GameObject myObject;
    
    public void Start()
    {
        myObject.transform.position = miVector;
    }
}
