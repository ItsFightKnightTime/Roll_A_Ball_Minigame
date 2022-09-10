using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Block_Movement : MonoBehaviour
{
    // Start and End Markers
    public Transform startMarker;
    public Transform endMarker;

    // Movement speed of Wall
    public float speed = 1.0F;

    // Time when movement started
    private float startTime;

    //Total distance between start and end markers
    private float journeyLength;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3.Lerp(transform.position)
    }
}
