using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Pad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler //모든 방향키에 넣어주세요
{
    public UserSystem UserSpeed;
    public static float moveSpeed;
    public static int State = 1;
    public GameObject Character;
    public GameObject AniChara;
    public static string ClickCheck = "false";

    public void OnPointerDown(PointerEventData MovePad) //오브젝트를 누르는중 작동
    {
        ClickCheck = gameObject.name; //누르고 있는 오브젝트의 이름을 받아온다
        if (SoundManager.SESoundSw == true) AniChara.GetComponent<AudioSource>().Play();
    }
    public void OnPointerUp(PointerEventData MovePad) //위것에 반대
    {
        ClickCheck = "false"; //변수 리셋
        AniChara.GetComponent<AudioSource>().Stop();
    }
    	
    void FixedUpdate() {
        if (UserSpeed != null)
        {
            moveSpeed = UserSpeed.moveSpeed;
        }
        else
        {
            moveSpeed = 1;
        }

        switch (ClickCheck)//누른 오브젝트의 이름에 따라서 이동 방향 결정
        {
            case "Up":
                Character.transform.Translate((Vector2.up * UserSystem.RotState) * moveSpeed * Time.smoothDeltaTime * State);
                AniChara.transform.rotation = Quaternion.Euler(0, 0, 180);                
                break;
            case "Down":
                Character.transform.Translate((Vector2.down * UserSystem.RotState) * moveSpeed * Time.smoothDeltaTime * State);
                AniChara.transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case "Left":
                Character.transform.Translate((Vector2.left * UserSystem.RotState) * moveSpeed * Time.smoothDeltaTime * State);
                AniChara.transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
            case "Right":
                Character.transform.Translate((Vector2.right * UserSystem.RotState) * moveSpeed * Time.smoothDeltaTime * State);
                AniChara.transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
        }

    }
}
