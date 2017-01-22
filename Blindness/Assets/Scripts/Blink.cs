using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

	public Animator anim;
	int num;



	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		num = Random.Range (1, 350);
		anim.SetInteger ("trigger", num);
	}
}
