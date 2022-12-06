using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject ObjectToFollow;

    private Vector3 _offSet = new Vector3(0, 0, -10); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(ObjectToFollow.position.x, transform.position.y, transform.position.z);
    }
}
