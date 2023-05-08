using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //references vehicle GameObject
    public GameObject player;

    // offset Vector3
    private Vector3 offset = new Vector3(0, 7.53f, -8.47f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // camera position = vechicle position + offset
        transform.position = player.transform.position + offset;
        
    }
}
