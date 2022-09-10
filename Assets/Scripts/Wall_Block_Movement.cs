using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Block_Movement : MonoBehaviour
{
    [SerializeField]
    private WaypointPath _waypointPath;

    [SerializeField]
    private float _speed;

    private int _targetWaypointIndex;
    
    private Transform _previousWaypoint;
    private Transform _targetWaypoint;

    private float _timeToWaypoint;
    private float _elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Moving to Target end postion
    void Update()
    {
      
    }
}
