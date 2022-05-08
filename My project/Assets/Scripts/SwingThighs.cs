using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class SwingThighs : MonoBehaviour  
{  
    Vector3 Vec;  
    // Start is called before the first frame update  
    void Start()  
    {  
          
    }  
  
    // Update is called once per frame  
    void Update()  
    {  
        if (Input.GetKey(KeyCode.X)) {
            Vec = transform.localPosition;  
            Vec.z += Input.GetAxis("Horizontal") * Time.deltaTime * 20;    
            transform.localPosition = Vec;  
        }
  
    }  
} 