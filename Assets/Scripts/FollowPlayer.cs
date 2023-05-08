using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //references vehicle GameObject
    public GameObject player;
    public GameObject secCam;

    // offset Vector3
    private Vector3 offset = new Vector3(0, 7.53f, -8.47f);
    private Vector3 switchOffset = new Vector3(-0.09f, 3.27f, 0.96f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // camera position = vechicle position + offset
        transform.position = player.transform.position + offset;
        secCam.transform.position = player.transform.position + switchOffset;
        
    }


}
