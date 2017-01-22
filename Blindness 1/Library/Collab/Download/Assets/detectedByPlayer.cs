using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class detectedByPlayer : MonoBehaviour {
	private Transform playerLocation;
	private Transform objectLocation;
	private new SpriteRenderer renderer;


	// Use this for initialization
	void Start ()
	{
		playerLocation = GameObject.Find("Character").transform;			// Used for finding the player's current position at each frame
		objectLocation = this.gameObject.transform;
		renderer = gameObject.GetComponent<SpriteRenderer>();				// Used for changing the color of the object the player is within range of
	}
	
	// Update is called once per frame
	/*void Update () 
	{
		Debug.Log("Player is at " + Math.Round(playerLocation.position.x, 2) + ", " + Math.Round(playerLocation.position.y, 2) +
				", Object is at " + Math.Round(objectLocation.position.x, 2) + ", " + Math.Round(objectLocation.position.y, 2) +
			"\nThe distance between the two is " + Math.Round(Math.Sqrt(Math.Pow(objectLocation.position.x - playerLocation.position.x, 2) + Math.Pow(objectLocation.position.y - playerLocation.position.y, 2)),2));
		if (Math.Round(Math.Sqrt(Math.Pow(objectLocation.position.x - playerLocation.position.x, 2) + Math.Pow(objectLocation.position.y - playerLocation.position.y, 2)),2) < 3)
			renderer.color = new Color(0, 0, 255);
		else
			renderer.color = new Color(255, 0, 0);
	}*/
	void OnTriggerEnter2D(Collider2D other)
	{
		renderer.color = new Color(0, 0, 255);
	}
	void OnTriggerExit2D(Collider2D other)
	{
		renderer.color = new Color(255, 0, 0);
	}
}