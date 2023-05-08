using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, 0, 1); // moves vehicle forward by changing the z value
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
        // Vector3 is a unit vector and forward is the direction the object is "looking at"
        // Time.deltaTime ensures that the speed is the same despite varying frame rates among computers
    }
}
