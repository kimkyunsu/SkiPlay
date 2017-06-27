using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseManagement : MonoBehaviour {

	public GameObject pauseMenu;

	private void start()
	{
		pauseMenu.SetActive (false);
	}

	public void TogglePauseMenu ()
	{
		pauseMenu.SetActive (!pauseMenu.activeSelf);
	}

	/*
	public void ToReplay ()
	{
		SceneManager.LoadScene ("");
	}
	*/

	public void ToMenu ()
	{
		SceneManager.LoadScene ("MainMenu");
	}



}
