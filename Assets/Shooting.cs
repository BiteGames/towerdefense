﻿using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public Rigidbody2D projectile;
	public float speed = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			Rigidbody2D instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation)as Rigidbody2D;

			instantiatedProjectile.velocity = transform.TransformDirection(new Vector2 (speed, 0));
		}

	}
}
