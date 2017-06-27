using UnityEngine;
using System.Collections;

public class ClickSound : MonoBehaviour {

	AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void Onhover()
    {
        if (SoundManager.SESoundSw == true) source.Play();
    }


	public void Onclick()
	{
        if (SoundManager.SESoundSw == true) source.Play();
    }
}