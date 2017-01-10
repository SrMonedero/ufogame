﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody2D rigidbody2D;

	void Start(){
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rigidbody2D.AddForce (movement * speed);
	}
}