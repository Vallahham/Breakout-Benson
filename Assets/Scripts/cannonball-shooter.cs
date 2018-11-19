﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	GameObject prefab;
	void Start () {
		prefab = Resources.Load("projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			GameObject projectile = Instantiate(prefab) as GameObject;
			projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
			Rigidbody rigbo = projectile.GetComponent<Rigidbody>();
			rigbo.velocity = Camera.main.transform.forward * 56;
	}
}
