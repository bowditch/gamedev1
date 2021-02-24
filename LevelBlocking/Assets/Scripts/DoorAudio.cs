
/***
John Bowditch - 20210224

Trigger Sound effect on collsion. Play once and die
Reuse for several gameobjects

***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAudio : MonoBehaviour
{
    public AudioSource triggeredSound;

    // Start is called before the first frame update
    void Start()
    {
        
        triggeredSound = GetComponent<AudioSource>();

        Debug.Log("I have found the audio source");

    }

    private void OnTriggerEnter(Collider other) 
    {

        triggeredSound.Play();

        Debug.Log("I have collided");
        
    }
}

