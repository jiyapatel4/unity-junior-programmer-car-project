using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class PlayerController : MonoBehaviour
{
    // speed vars
    private float speed = 25.0f;
    private float turnSpeed = 45.0f;
    // axis vars
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get user input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // move vehicle forward + backward
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);

        // rotate vehicle left + right
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        //NOTES:
        // Vector3 is a unit vector
        // Vector3.forward = (0, 0, 1) moves vehicle forward (forward is the direction the object is "looking at")
        // Vector3.right = (1, 0, 0) moves vehicle left/right
        // In rotate, the y value changes for the vehicle, so use Vector3.up = (0, 1, 0)
        // Time.deltaTime ensures that the speed is the same despite varying frame rates among computers
        // Input.GetAxis() returns indicated axis value with range [-1, 1]
    }
}
