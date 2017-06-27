using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
    Vector2 touchPos;
    Vector2 clickPos;
    RaycastHit2D hit;
    public Transform Player;
    public Camera UserCamera;
    public AudioSource SE;

    void InputDown()
    {
        if (hit)
        {
            if (hit.collider.tag == "teleportpoint")
            {
                Debug.Log("터치");
                gameObject.SetActive(false);
                Player.position = hit.collider.transform.position;
                if (SoundManager.SESoundSw == true) SE.Play();
            }
        }
    }

	void Update () {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                hit = Physics2D.Raycast(touchPos, Vector2.zero);

                InputDown();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(clickPos, Vector2.zero);

            InputDown();
        }
    }

    void OnDisable()
    {
        UserSystem.GetItem.gameObject.SetActive(false);
        Pad.State = 1;
        UserCamera.orthographicSize /= 2;
        UserSystem.TeleportOn = false;
    }
}
