//We want to click anywhere and have target move to spot.
//Using raycasts and need to track camera placement and mouse click placement

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class clickthenmove : MonoBehaviour
{

    public NavMeshAgent agent;

    public Transform rayObject;

    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        
        //Input controls
        //Raycast
        //Calculate a position for target

        if (Input.GetMouseButtonDown(0)) 
        {

            RaycastHit clickHit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out clickHit, 200))
            {

                agent.destination = clickHit.point;

            }

        }

        Ray lineRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(lineRay, out hit))
        {

            Vector3 incomingVector = hit.point - rayObject.position;

            Vector3 reflectionVector = Vector3.Reflect(incomingVector, hit.normal);

            //Debug.Drawline(start pos, end pos, color, duration, layerMask?)
            Debug.DrawLine(rayObject.position, hit.point, Color.blue, 4.0f);
            Debug.DrawRay(hit.point, reflectionVector, Color.red, 4.0f);

        }

    }
}
