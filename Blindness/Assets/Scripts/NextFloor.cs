using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextFloor : MonoBehaviour {

	void onTriggerEnter2D(Collider2D other)
	{
		SceneManager.LoadScene ("Lvl12ndFloor", LoadSceneMode.Additive);
	}
}
