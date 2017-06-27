using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

	public Sprite[] ChangeImg = new Sprite[4]; //바뀔이미지
	public Image CavasIamge;   //캔버스에 존하는 이미지
    public Image CanvasIamge;

    static public bool BgmSoundSw = true; //사운드 스위치
    static public bool SESoundSw = true;
    
    public void BGMplay()
	{
        if (BgmSoundSw == true)
        {
            CavasIamge.GetComponent<Image>().sprite = ChangeImg[1];
            this.GetComponent<AudioSource>().volume = 0;
            BgmSoundSw = false;
        }
        else
        {
            CavasIamge.GetComponent<Image>().sprite = ChangeImg[0];
            this.GetComponent<AudioSource>().volume = 1;
            BgmSoundSw = true;
        }
    }
    public void SEplay()
    {
        if (SESoundSw == true)
        {
            CanvasIamge.GetComponent<Image>().sprite = ChangeImg[3];
            SESoundSw = false;
        }
        else
        {
            CanvasIamge.GetComponent<Image>().sprite = ChangeImg[2];
            SESoundSw = true;
        }
    }

    void Awake()
    {
        BgmSoundSw = (PlayerPrefs.GetInt("BGMsw") == 1) ? true : false;
        SESoundSw = (PlayerPrefs.GetInt("SEsw") == 1) ? true : false;
        BGMplay();
        SEplay();
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("BGMsw", BgmSoundSw ? 0 : 1);
        PlayerPrefs.SetInt("SEsw", SESoundSw ? 0 : 1);
    }
}
