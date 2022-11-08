using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "1" )
        {
            print("hit 1st floor");
        }   
        else if(collision.gameObject.tag == "2")
        {
            print("hit 2nd floor");
        }
        else if(collision.gameObject.tag == "3")
        {
            print("hit 3th floor");
        }   
    }
}
