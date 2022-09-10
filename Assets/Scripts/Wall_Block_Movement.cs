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
        startTime = Time.time;

        // Journey Length
        journeyLength = Vector3.Distance(startMarker.position, endMarker.postion);
    }

    // Moving to Target end postion
    void Update()
    {
        // Distance between the two markers and its speed
        float distCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distCovered / journeyLength;

        // Complicated shit
       transform.position = new Vector3.Lerp(transform.position)
    }
}
