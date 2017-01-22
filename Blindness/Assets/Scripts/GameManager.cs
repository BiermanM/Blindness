using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
	public GameObject[] Door;
	public GameObject character;
	public int num;
	public Text timer;
	public Text GameOver;
	public float TimeLeft;

	// Use this for initialization
	void Start ()
	{
		num = Random.Range (0, 24);
		PlayerPrefs.SetInt ("Door", num);
		TimeLeft = 300f;
		GameOver.text = " ";
		
	}

	void FixedUpdate () 
	{
		TimeLeft -= Time.deltaTime;
		if (Mathf.RoundToInt (TimeLeft)%60 < 10)
			timer.text = "Time left\n" + (Mathf.RoundToInt (TimeLeft)/60)+":0"+ (Mathf.RoundToInt (TimeLeft)%60);
		else
			timer.text = "Time left\n" + (Mathf.RoundToInt (TimeLeft)/60)+":"+ (Mathf.RoundToInt (TimeLeft)%60);
		
		PlayerPrefs.SetInt ("Door", num);
			
		if (TimeLeft <= 0) 
		{
			timer.text = "Time left\n 0:00";
			character.SetActive (false);
			GameOver.text = "Game Over";
		}
	}

}



