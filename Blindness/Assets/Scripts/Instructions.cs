using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour {

	public GameObject text;
	public bool num;
	// Use this for initialization
	void Start()
	{
		num = false;
		text.SetActive(num);

	}
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			text.SetActive (!num);
            num = !num;
		}
	}
}
