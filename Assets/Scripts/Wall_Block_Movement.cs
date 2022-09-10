using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Block_Movement : MonoBehaviour
{
    // Start and End Markers
    public Transform startMarker;
    public Transform endMarker;
    
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
