using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMove : MonoBehaviour {

	Rigidbody2D rb;

	public float jumpForce;

	// Use this for initialization
	void Start () {

		// getting access to rigid body
		rb = GetComponent<Rigidbody2D>();

	}

	public void Jump(){
		rb.AddForce (new Vector2 (0, jumpForce));
	}
}
