using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ItemSetting : MonoBehaviour {


	public GameObject ItemBut;


	private void start()
	{
		ItemBut.SetActive (false);

		Screen.SetResolution (800, 1200, true);
	}

	public void ItemButMenu ()
	{
		ItemBut.SetActive (!ItemBut.activeSelf);
	}



}
