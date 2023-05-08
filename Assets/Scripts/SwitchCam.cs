using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    // reference main camera
    Camera mainCam;
    // reference secondary camera
    public Camera secCam;


    void Start()
    {
        // access main cam
        mainCam = Camera.main;

        //enable main and disable sec
        mainCam.enabled = true;
        secCam.enabled = false;
       
    }

    void Update()
    {
        // when L key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            // check if main cam is enabled
            if (mainCam.enabled)
            {
                mainCam.enabled = false;
                secCam.enabled = true;

            }
            else if (!mainCam.enabled)
            {
                mainCam.enabled = true;
                secCam.enabled = false;

            }

        }

    }    
        
    
}
