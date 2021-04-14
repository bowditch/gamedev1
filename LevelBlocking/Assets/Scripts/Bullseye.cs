using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullseye : MonoBehaviour
{

    public bool bullseyeImpact;

    void OnCollisionEnter(Collision collision) 
    {
        
        if (!bullseyeImpact)
        {

            bullseyeImpact = true;

            GameObject hitBullseye = gameObject.transform.gameObject;

            Animator bullseyeAnimator = hitBullseye.GetComponent<Animator>();

            bullseyeAnimator.SetTrigger("impact");

            

        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
