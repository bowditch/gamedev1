//This script is for counting gameobjects and then destroying the gameobject
//John Bowditch - 2021.02.03


//Libraries of scripts - Collection of scripts
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCounter : MonoBehaviour
{
    
    //int = whole number
    //float = 2.0

    public static int gemCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Best command for troubleshooting
        
        Debug.Log("Look ma, it works");

        //++GemCounter.gemCount;

    }

    private void OnTriggerEnter(Collider other) {

        Debug.Log("You've collected" + " a total of: " + ++gemCount);

        Destroy(gameObject);
        
    }
    
}