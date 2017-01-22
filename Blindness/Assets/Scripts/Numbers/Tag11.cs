﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag11 : MonoBehaviour 
{
	private int num;
	public int doornum;

	// Use this for initialization
	void Start () 
	{
		num = 11;
		doornum = PlayerPrefs.GetInt ("Door");

	}

	// Update is called once per frame
	void Update () 
	{	
		if (num == doornum) {
			gameObject.tag = "SecretDoor";
		}
		else
		{
			gameObject.tag = "Door";
		}
	}
}
