//Uses raycasting to move the bot to the selected area.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickThenMove : MonoBehaviour
{
    
    public GameObject ground;

    // Update is called once per frame
    void Update()
    {
        
        //Need camera calculated

        Transform camera = camera.main.transform;

        //Ray and click variables

        Ray clickRay;

        RaycastHit hit;

        GameObject hitObject;

        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward);

        //create new ray

        clickRay = new Ray(camera.position, camera.rotation * Vector3.forward);

        if(Physics.Raycast (clickRay, out hit))
        {
            
            hitObject = hit.collider.gamebject; 

        }

    }
}
