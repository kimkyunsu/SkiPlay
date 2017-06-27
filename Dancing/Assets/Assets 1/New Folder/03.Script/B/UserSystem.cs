using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class UserSystem : MonoBehaviour
{
    public float moveSpeed = 1;
    public Transform StartPoint;

    Sprite Save;
    public Image[] ItemTimerImage = new Image[4];
    public Text[] ItemTimer = new Text[4];
    float[] ItemTime = new float[4];

    public GameObject ItemPad;
    public static GameObject GetItem;
    public GameObject TeleportPoints;
    static public bool TeleportOn = false;
    public float CameraSize = 2;
    public GameObject DarkCircle;
    public static int RotState = 1;
    public GameObject GuideRoad;
    public Camera UserCamera;
    public Timeout timeout;

	AudioSource Col;
    public AudioSource ItemSounds;
    public AudioClip[] ItemSE = new AudioClip[2];

    void Start()
    {
        Col = GetComponent<AudioSource>();
        transform.position = StartPoint.transform.position; //유저 캐릭터 시작지점으로 이동
    }

    void Update()
    {
        for (int i = 0; i < 4; i++) {
            if (ItemTime[i] > 0)
            {
                ItemTime[i] -= Time.deltaTime;
                ItemTimer[i].text = ItemTime[i].ToString("N2");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "goal": //승리
                Debug.Log("Clear");
                Time.timeScale = 0;
                break;

            case "wallbreak": //이하 아이템들
                if (SoundManager.SESoundSw == true) Col.Play();                
                ItemPad.transform.position = other.transform.position;
                ItemPad.SetActive(true);
                GetItem = other.gameObject;
                Pad.State = 0;
                break;
            case "teleport":
                ItemSounds.clip = ItemSE[0];
                if (SoundManager.SESoundSw == true) Col.Play();
                other.gameObject.SetActive(false);
                TeleportPoints.SetActive(true);
                GetItem = other.gameObject;
                Pad.State = 0;
                UserCamera.orthographicSize *= CameraSize;
                TeleportOn = true;
                break;
            case "darkness":
                if (SoundManager.SESoundSw == true) Col.Play();
                other.gameObject.SetActive(false);
                Save = other.gameObject.GetComponent<SpriteRenderer>().sprite;
                StartCoroutine(Darkness());
                break;
            case "reverse":
                if (SoundManager.SESoundSw == true) Col.Play();
                other.gameObject.SetActive(false);
                Save = other.gameObject.GetComponent<SpriteRenderer>().sprite;               
                StartCoroutine(Reverse());
                break;
            case "speedup":
                if (SoundManager.SESoundSw == true) Col.Play();
                other.gameObject.SetActive(false);
                moveSpeed = 2;
                break;
            case "randomtime":
                if (SoundManager.SESoundSw == true) Col.Play();
                other.gameObject.SetActive(false);
                int TimeControl = Random.Range(0, 10);
                if (TimeControl < 7)
                {
                    timeout.outTime += 10;
                }
                else
                {
                    timeout.outTime -= 10;
                }
                break;
            case "guide":
                ItemSounds.clip = ItemSE[1];
                if (SoundManager.SESoundSw == true) ItemSounds.Play();
                other.gameObject.SetActive(false);
                Save = other.gameObject.GetComponent<SpriteRenderer>().sprite;
                StartCoroutine(Guide());
                break;
            case "securityofsight":
                if (SoundManager.SESoundSw == true) Col.Play();
                other.gameObject.SetActive(false);                
                Save = other.gameObject.GetComponent<SpriteRenderer>().sprite;
                StartCoroutine(SecurityOfSight());
                break;
        }
    }

    IEnumerator Darkness() //이하 아이템 기능과 지속시간 기능
    {
        DarkCircle.SetActive(true);
        for (int i = 0; i < 4; i++)
        {
            if (ItemTimerImage[i].sprite == null || ItemTimerImage[i].sprite == Save)
            {
                ItemTimerImage[i].gameObject.SetActive(true);
                ItemTimerImage[i].sprite = Save;
                ItemTime[i] = 15.00f;
            }
            else
            {
                continue;
            }

            yield return new WaitForSeconds(15);
            
            for (int j = 0; j < 3; j++)
            {
                if (ItemTimerImage[i + j + 1].sprite == null || i + j == 3)
                {
                    ItemTimerImage[i + j].gameObject.SetActive(false);
                    ItemTimerImage[i + j].sprite = null;
                    break;
                }
                else
                {
                    ItemTimerImage[i + j].sprite = ItemTimerImage[i + j + 1].sprite;
                    ItemTime[i + j] = ItemTime[i + j + 1];
                }
            }
            if (ItemTime[0] <= 0)
            {
                ItemTimerImage[0].gameObject.SetActive(false);
                ItemTimerImage[0].sprite = null;
            }
            break;
        }
        DarkCircle.SetActive(false);
    }
    IEnumerator Reverse()
    {
        transform.Rotate(0, 0, 180);
        RotState = -1;
        for (int i = 0; i < 4; i++)
        {
            if (ItemTimerImage[i].sprite == null || ItemTimerImage[i].sprite == Save)
            {
                ItemTimerImage[i].gameObject.SetActive(true);
                ItemTimerImage[i].sprite = Save;
                ItemTime[i] = 10.00f;
            }
            else
            {
                continue;
            }

            yield return new WaitForSeconds(10);

            for (int j = 0; j < 3; j++)
            {
                if (ItemTimerImage[i + j + 1].sprite == null || i + j == 3)
                {
                    ItemTimerImage[i + j].gameObject.SetActive(false);
                    ItemTimerImage[i + j].sprite = null;
                    break;
                }
                else
                {
                    ItemTimerImage[i + j].sprite = ItemTimerImage[i + j + 1].sprite;
                    ItemTime[i + j] = ItemTime[i + j + 1];
                }
            }
            if (ItemTime[0] <= 0)
            {
                ItemTimerImage[0].gameObject.SetActive(false);
                ItemTimerImage[0].sprite = null;
            }
            break;
        }
        transform.rotation = Quaternion.identity;
        RotState = 1;        
    }
    IEnumerator Guide()
    {
        GuideRoad.SetActive(true);
        for (int i = 0; i < 4; i++)
        {
            if (ItemTimerImage[i].sprite == null || ItemTimerImage[i].sprite == Save)
            {
                ItemTimerImage[i].gameObject.SetActive(true);
                ItemTimerImage[i].sprite = Save;
                ItemTime[i] = 10.00f;
            }
            else
            {
                continue;
            }

            yield return new WaitForSeconds(10);

            for (int j = 0; j < 3; j++)
            {
                if (ItemTimerImage[i + j + 1].sprite == null || i + j == 3)
                {
                    ItemTimerImage[i + j].gameObject.SetActive(false);
                    ItemTimerImage[i + j].sprite = null;
                    break;
                }
                else
                {
                    ItemTimerImage[i + j].sprite = ItemTimerImage[i + j + 1].sprite;
                    ItemTime[i + j] = ItemTime[i + j + 1];
                }
            }
            if (ItemTime[0] <= 0)
            {
                ItemTimerImage[0].gameObject.SetActive(false);
                ItemTimerImage[0].sprite = null;
            }
            break;
        }
        GuideRoad.SetActive(false);
    }
    IEnumerator SecurityOfSight()
    {
        UserCamera.orthographicSize = 6;
        UserCamera.transform.localPosition = new Vector3(0, -0.287f, -10f);
        for (int i = 0; i < 4; i++)
        {
            if (ItemTimerImage[i].sprite == null || ItemTimerImage[i].sprite == Save)
            {
                ItemTimerImage[i].gameObject.SetActive(true);
                ItemTimerImage[i].sprite = Save;
                ItemTime[i] = 15.00f;
            }
            else
            {
                continue;
            }

            yield return new WaitForSeconds(15);

            for (int j = 0; j < 3; j++)
            {
                if (ItemTimerImage[i + j + 1].sprite == null || i + j == 3)
                {
                    ItemTimerImage[i + j].gameObject.SetActive(false);
                    ItemTimerImage[i + j].sprite = null;
                    break;
                }
                else
                {
                    ItemTimerImage[i + j].sprite = ItemTimerImage[i + j + 1].sprite;
                    ItemTime[i + j] = ItemTime[i + j + 1];
                }
            }
            if (ItemTime[0] <= 0)
            {
                ItemTimerImage[0].gameObject.SetActive(false);
                ItemTimerImage[0].sprite = null;
            }
            break;
        }
        if (TeleportOn == false)
            UserCamera.orthographicSize = 3;
        UserCamera.transform.localPosition = new Vector3(0, -0.144f, -10f);
    }    
}