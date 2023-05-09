using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class PlayerController : MonoBehaviour
{
    // differentiates between player 1 and 2
    public string playerID;
    // differentiates between "L" and "Q" key press
    public KeyCode switchKey;

    // speed vars
    private float speed = 25.0f;
    private float turnSpeed = 45.0f;

    // user input axis vars
    private float horizontalInput;
    private float forwardInput;

    // references main vehicle camera
    public Camera mainCam;
    // references secondary camera
    public Camera secCam;

    // Start is called before the first frame update
    void Start()
    {
        //enable main camera and disable secondary camera upon start
        mainCam.enabled = true;
        secCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // get user input based on player 1 or 2
        horizontalInput = Input.GetAxis("Horizontal" + playerID);
        forwardInput = Input.GetAxis("Vertical" + playerID);

        // move vehicle forward and backward
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);

        // rotate vehicle left and right
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);



        // when L or Q key is pressed
        if (Input.GetKeyDown(switchKey))
        {
            // check if main camera is enabled
            if (mainCam.enabled)
            {
                // disable main camera
                mainCam.enabled = false;
                secCam.enabled = true;

            }
            // check if main camera is disabled
            else if (!mainCam.enabled)
            {
                // enable main camera
                mainCam.enabled = true;
                secCam.enabled = false;

            }

        }

        //NOTES:
        // Vector3 is a unit vector
        // Vector3.forward = (0, 0, 1) moves vehicle forward (forward is the direction the object is "looking at")
        // Vector3.right = (1, 0, 0) moves vehicle left/right
        // In rotate, the y value changes for the vehicle, so use Vector3.up = (0, 1, 0)
        // Time.deltaTime ensures that the speed is the same despite varying frame rates among computers
        // Input.GetAxis() returns indicated axis value with range [-1, 1]
    }
}
