using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class EffectSoundManager : MonoBehaviour {


	public Sprite[] ChangeImg; 
	public Image CavasIamge;  




	public AudioClip Col;

	private Button button { get { return GetComponent<Button> (); } }
	private AudioSource source { get { return GetComponent<AudioSource> (); } }

	void start () {

		gameObject.AddComponent<AudioSource> ();
		source.clip = Col;
		source.playOnAwake = false;

		button.onClick.AddListener (() => PlaySound ());
	}

	public void PlaySound()
	{
		source.PlayOneShot (Col);
	}





}