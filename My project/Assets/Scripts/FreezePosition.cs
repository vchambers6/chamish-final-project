using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePosition : MonoBehaviour
{
    public GameObject TheThingToFreeze;
  	
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TheThingToFreeze.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;  
        }
    }
 
}    
