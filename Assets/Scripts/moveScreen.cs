﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScreen : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * speed * Time.deltaTime);
		
	}
	public void Stop()
	{
		speed = 0;
	}
}
