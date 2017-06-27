using UnityEngine;
using System.Collections;

public class TouchSetting : MonoBehaviour {

	public GameObject Setting;
	
	// Update is called once per frame

		void Update () {
			if (Application.platform == RuntimePlatform.Android) {
				if (Input.GetKey (KeyCode.Escape)) 

				{
					Debug.Log ("finshgame");
					Setting.SetActive(true);
				}
			}
		}

}
