using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class Preloder : MonoBehaviour
{

	public CanvasGroup fadeGroup;
	public float loadTime;
	public float minimumLogoTime = 3.0f;


	public void start ()
	{
		fadeGroup = FindObjectOfType <CanvasGroup> ();

		fadeGroup.alpha = 1;

		if (Time.time < minimumLogoTime)
			loadTime = minimumLogoTime;
		else
			loadTime = Time.time;
		
	}



	public void Update ()

	{
		if (Time.time < minimumLogoTime) 
		{
			fadeGroup.alpha = 1 - Time.time;
		}
	
		if (Time.time > minimumLogoTime && loadTime != 0)
		{
			fadeGroup.alpha = Time.time - minimumLogoTime;
			if (fadeGroup.alpha >= 1)
			{	
				SceneManager.LoadScene("02_TitleUI");
			}

		}
	}
}