﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed=3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.A))
	    {
	        transform.Translate(new Vector3(-Speed*Time.deltaTime,0,0));
	    }
	    if (Input.GetKey(KeyCode.D))
	    {
	        transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0));
	    }
	    if (Input.GetKey(KeyCode.W))
	    {
	        transform.Translate(new Vector3(0, Speed * Time.deltaTime,  0));
	    }
	    if (Input.GetKey(KeyCode.S))
	    {
	        transform.Translate(new Vector3(0, -Speed * Time.deltaTime, 0));
	    }
    }
}
