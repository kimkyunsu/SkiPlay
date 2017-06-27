using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Loder : MonoBehaviour {

	public void Awake()
	{
		
		Screen.SetResolution (800, 1200, true);
	}

	public float delayTime = 3;

	IEnumerator Start () {
		
		yield return new WaitForSeconds( delayTime );

		SceneManager.LoadScene ("UI");
	}


}
