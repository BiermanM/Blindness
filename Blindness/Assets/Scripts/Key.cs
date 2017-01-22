using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Key : MonoBehaviour {

	public Text Box;
	public int num;

	// Use this for initialization
	void Start () 
	{
		num = PlayerPrefs.GetInt ("Door");
		Box.text = " ";

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Door") 
		{
			Box.text = "Wrong door, this is "+other.name+", you should head to " + num;
		}
		if (other.gameObject.tag == "SecretDoor") 
		{
			gameObject.SetActive (false);
			Box.text = "Congrats on making it to class on time!";
		}


	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
