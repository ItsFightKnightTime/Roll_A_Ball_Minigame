using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Movement : MonoBehaviour
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

    void Update()
    {
        _elapsedTime += Time.deltaTime;

        float elapsedPercentage = _elapsedTime / _timeToWaypoint;
        transform.position = Vector3.Lerp(_previousWaypoint.position, _targetWaypoint.postion, elapsedPercentage);

        if (elapsedPercentage >= 1)
        {
            TargetNextWaypoint();
        }
    }

    private void TargetNextWaypoint()
    {
        _previousWaypoint = _waypointPath.GetWaypoint(_targetWaypointIndex);
        _targetWaypointIndex = _waypointPath.GetNextWaypointIndex(_targetWaypointIndex);
        _targetWaypoint = _waypointPath.GetWaypoint(_targetWaypointIndex);

        _elapsedTime = 0;

        float distanceToWaypoint = Vector3.Distance(_previousWaypoint.postion, _targetWaypoint.postion);
        _timeToWaypoint = distanceToWaypoint / _speed;
    }
}
