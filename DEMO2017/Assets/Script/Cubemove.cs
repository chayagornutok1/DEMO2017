﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubemove : MonoBehaviour {
	public Rigidbody rg;
	public float velocity;
	// Use this for initialization
	void Start () {
		rg.velocity = new Vector3 (velocity ,0,0);
		//rg.velocity = new Vector3 (-1, 0, 0);
		//rg.AddForce(-2,0,0);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "floor")
			Destroy (collision.gameObject);

	}
}
