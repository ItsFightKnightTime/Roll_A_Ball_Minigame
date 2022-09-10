using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Movement : MonoBehaviour
{
   public Transform GetWaypoint(int waypointIndex)
   {
        return transform.GetChild(waypointIndex);
   }

    public int GetNextWaypointIndex(int currentWaypoint)
    {
        
    }