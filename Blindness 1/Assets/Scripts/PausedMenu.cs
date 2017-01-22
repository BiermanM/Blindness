using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour {

    public GameObject PausedUI;
    private bool paused = false;

    void Start()
    {
        PausedUI.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
            PausedUI.SetActive(paused);
        }

        if (paused)
        {
            PausedUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused)
        {
            PausedUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Resume()
    {
        paused = false;
    }

	public void NewGame()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

    public void MainMenu()
    {
		SceneManager.LoadScene ("TitleScreen");
    }
	public void QuitGame()
	{
		Application.Quit ();
	}
}
