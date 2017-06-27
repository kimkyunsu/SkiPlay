using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;



public class UImanagement : MonoBehaviour {

	public GameObject FinshNO;

		
	public void startBut()
	{
		SceneManager.LoadScene ("03_Tutorial");
	}

	public void ToggleFinshEnd ()
	{
		FinshNO.SetActive (!FinshNO.activeSelf);

	}

}
