using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TouchMainMenu : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) 
			
			{
				SceneManager.LoadScene ("MainMenu");
			}
		}
	}
}

