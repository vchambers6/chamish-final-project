using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePosition : MonoBehaviour
{
    public GameObject TheThingToFreeze;
  	
   //  public void	Start()
   //  {
   //  	if (Input.GetKeyDown(KeyCode.Space))
   //  	{
			// TheThingToFreeze.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;  
   //  	}
   //  }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TheThingToFreeze.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;  
        }
    }
    
}    
