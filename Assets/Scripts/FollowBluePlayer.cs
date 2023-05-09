using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBluePlayer : MonoBehaviour
{
    // reference blue vehicle object and secondary blue camera
    public GameObject player;
    public GameObject secCam;

    // camera offsets
    private Vector3 offset = new Vector3(0.0f, 9.2f, -14.4f);
    private Vector3 switchOffset = new Vector3(0.0f, 1f, 1.55f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // make main camera follow blue player
        transform.position = player.transform.position + offset;

        // make secondary camera follow blue player
        secCam.transform.position = player.transform.position + switchOffset;


    }
}
