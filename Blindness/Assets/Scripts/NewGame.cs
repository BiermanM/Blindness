using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour {

	public bool fact;
	public GameObject text2;
	public GameObject text;
	// Use this for initialization
	void Start ()
	{
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.SetActive (fact);
		text2.SetActive (!fact);
	}
	public void Open()
	{
		Application.LoadLevel (1);
	}
	public void Appear()
	{
		fact =!fact;
	}
}
