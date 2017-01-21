using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Animator anim;
	public float Speed = 5.0f;
	public Rigidbody2D rb;
	 

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			anim.SetInteger("Walk", 1);
			//rb.AddForce(transform.up * -Speed);
			rb.velocity = new Vector2(0, -Speed*Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			anim.SetInteger("Walk", 2);
			//rb.AddForce (transform.right * Speed);
			rb.velocity = new Vector2(Speed*Time.deltaTime,0);
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			anim.SetInteger("Walk", -1);
			//rb.AddForce (transform.up * Speed);
			rb.velocity = new Vector2(0, Speed*Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			anim.SetInteger("Walk", -2);
			//rb.AddForce (transform.right * -Speed);
			rb.velocity = new Vector2(-Speed*Time.deltaTime,0);
		}

		//-----------------------------------------------------------
		if (Input.GetKeyUp(KeyCode.S))
		{
			anim.SetInteger ("Walk", 0);
			rb.velocity = new Vector2(0,0);
		}	
		if (Input.GetKeyUp(KeyCode.D))
		{
			anim.SetInteger ("Walk", 0);
			rb.velocity = new Vector2(0,0);
		}
		if (Input.GetKeyUp(KeyCode.W))
		{
			anim.SetInteger ("Walk", 0);
			rb.velocity = new Vector2(0,0);
		}	
		if (Input.GetKeyUp(KeyCode.A))
		{
			anim.SetInteger ("Walk", 0);
			rb.velocity = new Vector2(0,0);
		}
	}
}
