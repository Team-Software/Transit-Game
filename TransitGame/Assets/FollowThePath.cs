using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePath : MonoBehaviour {

	// Array of waypoints to walk from one to the next one
	[SerializeField]
	Transform[] waypoints;

	// Walk speed that can be set in Inspector
	[SerializeField]
	float moveSpeed = 50f;

	// Index of current waypoint from which Enemy walks
	// to the next one
	int waypointIndex = 0;

	// Use this for initialization
	void Start () {

		// Set position of Enemy as position of the first waypoint
		transform.position = waypoints[waypointIndex].transform.position;
	}

	// Update is called once per frame
	void Update () {

		// Move Enemy
		Move();
	}

	// Method that actually make Enemy walk
	void Move()
	{
		 
		// If Enemy didn't reach last waypoint it can move
		// If enemy reached last waypoint then it stops
		if (waypointIndex <= waypoints.Length - 1)
		{

			// Move Enemy from current waypoint to the next one
			// using MoveTowards method
			transform.position = Vector2.MoveTowards(transform.position,
				waypoints[waypointIndex].transform.position,
				moveSpeed * Time.deltaTime);

			// If Enemy reaches position of waypoint he walked towards
			// then waypointIndex is increased by 1
			// and Enemy starts to walk to the next waypoint
			if (transform.position == waypoints[waypointIndex].transform.position)
			{
				waypointIndex += 1;
			}
		}
	}
}
