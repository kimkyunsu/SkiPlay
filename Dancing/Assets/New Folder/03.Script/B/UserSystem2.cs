using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class UserSystem2 : MonoBehaviour
{
    public float moveSpeed = 1;
    public Transform StartPoint;

	AudioSource Col;

    void Start()
    {
        Col = GetComponent<AudioSource>();
        transform.position = StartPoint.transform.position; //유저 캐릭터 시작지점으로 이동
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "goal": //승리
                Debug.Log("Clear");
                Time.timeScale = 0;
                break;

            case "illusion": //신기루골
                other.transform.Find("Fake").gameObject.SetActive(false);
                other.GetComponent<SpriteRenderer>().enabled = true;
                if (SoundManager.SESoundSw == true) Col.Play();
                break;
        }
    }
}