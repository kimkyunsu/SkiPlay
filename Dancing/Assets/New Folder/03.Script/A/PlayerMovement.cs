using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	//별 이미지에 대한 참조
	private GameObject star1;
	private GameObject star2;
	private GameObject star3;


	//다음 이미지에 대한 참조
	private GameObject buttonNext;
	private GameObject Replaybut;
	private GameObject Stagebut;
	private GameObject Mainbut;
	private GameObject Cleartext;
	private GameObject ClearPanel;


	protected string currentLevel;
	protected int worldIndex;
	protected int levelIndex;
	bool isLevelComplete ;
	//타이머 텍스트 참조
	public Text timerText;
	//레벨 시작 후 경과 시간
	protected float totalTime = 0f;

    float timeCut; //별 매기는 기준 시간

	// Use this for initialization
	void Start () {
        timeCut = Timeout.staticTime2;
        Time.timeScale = 1;
		//레벨 시작시 레벨 완료를 false로 설정합니다.
		isLevelComplete = false;
		//별 오브젝트 찾아오기
		star1 = GameObject.Find("star1");
		star2 = GameObject.Find("star2");
		star3 = GameObject.Find("star3");
		Cleartext = GameObject.Find ("ClearText");
		ClearPanel = GameObject.Find ("Image");
		//별 오브젝트 찾아오기
		buttonNext = GameObject.Find("Next");
		Replaybut = GameObject.Find ("Replay");
		Stagebut = GameObject.Find ("StageSelect");
		Mainbut = GameObject.Find ("MainMenu");
		//모든 별 이미지의 이미지 구성 요소 비활성화
		star1.GetComponent<Image>().enabled = false;
		star2.GetComponent<Image>().enabled = false;
		star3.GetComponent<Image>().enabled = false;
		ClearPanel.GetComponent<Image> ().enabled = false;
		Cleartext.GetComponent<Text> ().enabled = false;
		timerText.GetComponent<Text> ().enabled = false;
		//버튼 찾아서 눌르기
		buttonNext.SetActive(false);
		Replaybut.SetActive(false);
		Stagebut.SetActive(false);
		Mainbut.SetActive(false);
		//현재 레벨 이름 저장
		currentLevel = SceneManager.GetActiveScene().name;
	}

	// Update is called once per frame
	void Update () {
		// 레벨완료 체크
		/*if(!isLevelComplete){
			//Debug.Log(totalTime);
			//왼쪽 및 오른쪽 화살표 키를 기준으로 플레이어 이동
			transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*10f, 0, 0); 
		}*/
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name=="Goal"){
			//플레이어가 이름이 Goal 인 객체를 명중하면 isLevelComplete 플래그를 true로 설정
			isLevelComplete = true;

            //타이머 값을 갱신한다.
            totalTime += Timeout.staticTime2 - Timeout.staticTime;
            //타이머 값을 표시한다 
            timerText.text = totalTime.ToString("N2");

            if (totalTime <= timeCut / 3)
            {
                star3.GetComponent<Image>().enabled = true;
                UnlockLevels(3);   //차기 레벨 기능 잠금 해제  
            }
            else if (totalTime <= timeCut * 2 / 3)
            {
                star2.GetComponent<Image>().enabled = true;
                UnlockLevels(2);
            }
            else if (totalTime < timeCut)
            {
                star1.GetComponent<Image>().enabled = true;
                UnlockLevels(1);
            }

			ClearPanel.GetComponent<Image> ().enabled = (true);
			Cleartext.GetComponent<Text>().enabled = (true);
			timerText.GetComponent<Text>().enabled = (true);
			buttonNext.SetActive (true);
			Replaybut.SetActive(true);
			Stagebut.SetActive(true);
			Mainbut.SetActive(true);
            if (SoundManager.SESoundSw == true && isLevelComplete == false) GetComponent<AudioSource>().Play();

        }
    }

	protected void  UnlockLevels (int stars){

		// 다음 레벨의 playerprefs 값을 1로 설정하여 잠금 해제
		// 월드 레벨 메뉴에 별의 playerprefs 값을 표시하도록 설정
		for(int i = 0; i < LockLevel.worlds; i++){
			for(int j = 1; j < LockLevel.levels; j++){               
				if(currentLevel == "Level"+(i+1).ToString() +"." +j.ToString()){
					worldIndex  = (i+1);
					levelIndex  = (j+1);
					PlayerPrefs.SetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString(),1);
					//현재 별 값이 새 값보다 작은 지 확인
					if(PlayerPrefs.GetInt("level"+worldIndex.ToString() +":" +j.ToString()+"stars")< stars)
						//별 값을 새 값으로 덮어.
						PlayerPrefs.SetInt("level"+worldIndex.ToString() +":" +j.ToString()+"stars",stars);
				}
			}
		}

	}


}