using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timeout : MonoBehaviour {
    public float outTime = 90;
    static public float staticTime;
    static public float staticTime2;
    public Text TimeText;
    public Text Countdown;
    public AudioSource CountSE;
    public GameObject FailPanel; //실패 결과창 받기

   IEnumerator Count()
    {
        Countdown.text = "3";
        if (SoundManager.SESoundSw == true) CountSE.Play();
        yield return new WaitForSecondsRealtime(1);
        Countdown.text = "2";
        if (SoundManager.SESoundSw == true) CountSE.Play();
        yield return new WaitForSecondsRealtime(1);
        Countdown.text = "1";
        if (SoundManager.SESoundSw == true) CountSE.Play();
        yield return new WaitForSecondsRealtime(0.75f);
       CountSE.Stop();
        yield return new WaitForSeconds(0.25f);
      Countdown.enabled = false;
   }

    void Awake()
    {
        staticTime = outTime;
        staticTime2 = outTime;
    }

    void Start()
    {
//        StartCoroutine(Count());
    }

    void Update () {
        staticTime = outTime;

        if (Countdown.enabled == false)
        {
            outTime -= Time.deltaTime;
            TimeText.text = outTime.ToString("N2");
        }

        if (outTime <= 0)
        {
            Debug.Log("gameover");
            Time.timeScale = 0;
            outTime = 0;
            FailPanel.SetActive(true);
            if (SoundManager.SESoundSw == true) GetComponent<AudioSource>().Play();
        }
	
	}
}
