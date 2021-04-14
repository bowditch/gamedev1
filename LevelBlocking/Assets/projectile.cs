using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    
    public GameObject ballAmmo;

    public float projectileVelocity = 500f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetButtonDown("Fire1"))
         {

            GameObject ball = Instantiate(ballAmmo, gameObject.transform.position, gameObject.transform.rotation);

            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, projectileVelocity, 0));

        }
    }
}
