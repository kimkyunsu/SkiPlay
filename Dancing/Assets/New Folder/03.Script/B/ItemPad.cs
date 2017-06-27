using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

[RequireComponent(typeof(AudioSource))]
public class ItemPad : MonoBehaviour
{
    Vector2 touchPos;
    Vector2 clickPos;
    RaycastHit2D hit; //패드
    RaycastHit2D hit2; //벽
    public float rayLength = 1f;
    public LayerMask[] checkLayer = new LayerMask[2];
    public GameObject UserCamera;
    bool check = false;

    void InputDown()
    {
        if (hit)
        {
            if (hit.collider.tag == "itempad" && check == false)
            {
                Debug.Log("눌렀다");
                hit.collider.GetComponent<SpriteRenderer>().color = Color.red;
                hit2 = Physics2D.Raycast(hit.transform.position, Vector2.zero, rayLength, checkLayer[1]);
            }
        }
    }
    IEnumerator InputUp()
    {
        if (hit.collider.tag == "itempad" && check == false)
        {
            Debug.Log("땠다");
            hit.collider.GetComponent<SpriteRenderer>().color = Color.white;
            if (hit2)
            {
                check = true;
                hit2.collider.gameObject.SetActive(false);
                iTween.ShakePosition(UserCamera, new Vector2(0.25f, 0.25f), 1);
                if (SoundManager.SESoundSw == true) GetComponent<AudioSource>().Play();
                UserSystem.GetItem.SetActive(false);
                yield return new WaitForSeconds(1);                
                Pad.State = 1;
                gameObject.SetActive(false);
            }
        }
    }

    void Update () {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                hit = Physics2D.Raycast(touchPos, Vector2.zero, rayLength, checkLayer[0]);
                InputDown();
            }
        }
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {                
                if (hit)
                {
                    StartCoroutine(InputUp());
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(clickPos, Vector2.zero, rayLength, checkLayer[0]);
            InputDown();
        }
        if (Input.GetMouseButtonUp(0))
        {            
            if (hit)
            {
                StartCoroutine(InputUp());
            }
        }
    }
    void OnDisable()
    {
        hit = new RaycastHit2D();
        hit2 = new RaycastHit2D();
        check = false;
    }
}
