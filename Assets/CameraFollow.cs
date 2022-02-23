using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerPosition;
    public Vector3 offset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       transform.position = new Vector3(playerPosition.position.x,playerPosition.position.y, playerPosition.position.z + offset.z);

    }
}
