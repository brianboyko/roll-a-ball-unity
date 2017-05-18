using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed; 

	private Rigidbody rb;

	void Start (){
		rb = GetComponent<Rigidbody> ();
	}

	// FixedUpdate is performed just before rendering any physics
	// calculations
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); 

		rb.AddForce (movement * speed);
	}
	// apply that input to the Player as movement.
}
