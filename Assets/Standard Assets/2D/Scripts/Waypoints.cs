using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoin : MonoBehaviour
{
     [SerializeField]
    private float moveSpeed = 2f;

    [SerializeField]
    private Transform[] waypoints;

    private int waypointIndex = 0;

    // Update is called once per frame
    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
        else
        {
            waypointIndex = 0;
        }
    }
    
}
