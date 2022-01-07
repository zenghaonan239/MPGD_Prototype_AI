using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;

    private int waypointIndex;
    private float dist;

    void Start()
    {
        //waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);

    }

    void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (dist < 1f)
        {
            increaseIndex();
        }
        patrol();
    }

    void patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void increaseIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }

}
