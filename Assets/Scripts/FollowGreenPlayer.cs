using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGreenPlayer : MonoBehaviour
{

    // references vehicle game object and secondary green camera
    public GameObject player;
    public GameObject secCam;

    // offset Vector3
    private Vector3 offset = new Vector3(0.0f, 7.53f, -8.47f);
    private Vector3 switchOffset = new Vector3(0.0f, 3.27f, 0.96f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // make main camera follow green player
        transform.position = player.transform.position + offset;
        // make secondary camera follow green player
        secCam.transform.position = player.transform.position + switchOffset;
        
    }

    //NOTES:
    // main camera position = vechicle position + offset


}
