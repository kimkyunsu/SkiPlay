using UnityEngine;
using System.Collections;

public class TouchExit : MonoBehaviour {

	public GameObject Finshgame;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) 

			{
				Debug.Log ("finshgame");
				Finshgame.SetActive(true);
			}
		}
	}

	public void AppQuit()
	{

				Application.Quit ();

	}
}
