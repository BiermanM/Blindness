using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class detectedByPlayer : MonoBehaviour {
	private new SpriteRenderer renderer;
	public float alpha = 0;
	public float red, green, blue = 0;


	// Use this for initialization
	void Start ()
	{
		renderer = gameObject.GetComponent<SpriteRenderer>();				// Used for changing the color of the object the player is within range of
		red = renderer.color.r;
		green = renderer.color.g;
		blue = renderer.color.b;
	
		renderer.color = new Color (0, 0, 0, 0);
	}

	IEnumerator OnTriggerEnter2D(Collider2D other)
	{
		if (renderer.color.r == 0 && renderer.color.g == 0 && renderer.color.b == 0)
		{
			
			for (float x = 0f; x < 4.637f; x += (10f * 0.018548f)) {
				alpha = Convert.ToSingle ((255f / 1.143f) * ((4.0f * Math.Pow (Math.Sin (x), 2f)) / (x + 2f)));
				renderer.color = new Color (red, green, blue, alpha / 255f);

				yield return new WaitForSeconds (0.001f);
			}

			gameObject.GetComponent<BoxCollider2D> ().size = new Vector3 (0, 0);

			alpha = 0.519779f;
			renderer.color = new Color (red, green, blue, alpha);
			for (int x = 0; x < 255; x++)
			{
				if (renderer.color.r <= 0)
					break;
				alpha -= 1f / 255f;
				renderer.color = new Color (red, green, blue, alpha);
				yield return new WaitForSeconds (0.07f);
			}

			gameObject.GetComponent<BoxCollider2D> ().size = new Vector3 (2.5f, 2f);
			renderer.color = new Color (0, 0, 0, 0);
		}
	}
	void OnTriggerExit2D(Collider2D other)
	{

	}
}