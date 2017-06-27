using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IllusionStageSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void illusionStage ()
	{
		SceneManager.LoadScene ("Level2.1");
	}


}
