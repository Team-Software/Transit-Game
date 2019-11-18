using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	float speedForce = 7f;
	float torqueForce = -35f;
	float drifFactor = 0.999f;

	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		//verificar si el boton up/down here, the set a bool that you will use in FixedUpdate
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();

		rb.velocity = ForwardVelocity ();// + RightVelocity() * drifFactor;

		if (Input.GetButton ("Accelerate")) {//Si se matiene apretado el boton
			rb.AddForce(transform.up * speedForce);
		}

		if (Input.GetButton ("Brakes")) {//Si se matiene apretado el boton
			rb.AddForce(transform.up * -speedForce);
		}

		float tf = Mathf.Lerp(0, torqueForce, rb.velocity.magnitude/5);

		rb.angularVelocity = Input.GetAxis ("Horizontal") * tf;



	}

	Vector2 ForwardVelocity(){
		return transform.up * Vector2.Dot (GetComponent<Rigidbody2D>().velocity, transform.up);
	}
	Vector2 RightVelocity(){
		return transform.right * Vector2.Dot (GetComponent<Rigidbody2D>().velocity, transform.right);
	}
}
