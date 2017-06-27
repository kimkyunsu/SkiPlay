using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class UserSystem3 : MonoBehaviour
{
    public float moveSpeed = 1;
    public Transform StartPoint;
    
    int havekey;
    public Image[] Keys = new Image[3];
    public int Object;
    
	AudioSource Col;
    public AudioSource Unlock;
    
    void Start()
    {
        Col = GetComponent<AudioSource>();
        transform.position = StartPoint.transform.position; //유저 캐릭터 시작지점으로 이동
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "key": //탈출 모드용
                other.gameObject.SetActive(false);
                if (SoundManager.SESoundSw == true) Col.Play();
                havekey++;
                Keys[havekey - 1].color = new Color(1, 1, 1);
                break;
            case "lock":
                if(havekey == Object)
                {
                    other.gameObject.SetActive(false);
                    Keys[0].GetComponentInParent<Transform>().gameObject.SetActive(false);
                    Unlock.Play();
                }
                break;
            case "esgoal":
                if (havekey == Object)
                {
                    Debug.Log("Clear");
                    Time.timeScale = 0;
                }
                break;
                
        }
    }
    
}