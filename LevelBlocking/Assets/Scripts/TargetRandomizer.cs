//John Bowditch 2021.03.24
//Basic AI Target randomizer based off a selected range

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRandomizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine (RepositionWithDelay());

    }

    //Calculate math. 
    IEnumerator RepositionWithDelay()
    {

        while(true){

            RandomPosition();

            yield return new WaitForSeconds(5);
        }

    }


    void RandomPosition()
    {

        //Need variables for x and z axes. We need to set a range.

        float xAxis = Random.Range(-20.0f, 20.0f);

        float zAxis = Random.Range(-30.0f, 30.0f);

        Debug.Log("X,Z:" + xAxis.ToString("F2") + ", " + zAxis.ToString("F2"));

        transform.position = new Vector3(xAxis, 0.0f, zAxis);

    }


}
