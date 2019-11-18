using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSpritePath : MonoBehaviour {
	GameObject pathGO;

	Transform targetPathNote;
	int pathNodeIndex=0;

	float speed = 20f;
	// Use this for initialization
	void Start () {
		pathGO = GameObject.Find ("Path2D");

	}
	
	void GetNextPathNode(){
		targetPathNote = pathGO.transform.GetChild (pathNodeIndex);
		pathNodeIndex++;
	}

	// Update is called once per frame
	void Update () {
		if (targetPathNote == null) {
			GetNextPathNode();
			if (targetPathNote == null) {
				//We've run out of path!
				ReachedGoal();
			}
		}

		Vector2 dir = targetPathNote.position - this.transform.localPosition;
		//Vector2 dir2 = targetPathNote.position - this.transform.localPosition;

		float distThisFrame = speed * Time.deltaTime;

		if (dir.magnitude <= distThisFrame) {
			//we reached the node
			targetPathNote = null;
		} 
		else {
			//Move towards node
			transform.Translate(dir.normalized * distThisFrame, Space.World);
			Quaternion targetRotation = Quaternion.LookRotation (dir);
			this.transform.rotation = Quaternion.Lerp (this.transform.rotation, Quaternion.FromToRotation(transform.position,targetPathNote.transform.position - transform.position), Time.deltaTime);
			//this.transform.localRotation =Quaternion.Lerp (this.transform.rotation, targetRotation, Time.deltaTime);
		}
	}


	void ReachedGoal(){
		Destroy (gameObject);
	}
}
	