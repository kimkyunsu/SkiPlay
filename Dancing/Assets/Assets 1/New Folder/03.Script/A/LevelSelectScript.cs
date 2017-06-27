using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour {
	private int worldIndex;   
	private int levelIndex;
	//획득 한 별을 보유하는 변수    
	private int stars=0;

	void  Start (){
		//세계를 순환
		for(int i = 1; i <= LockLevel.worlds; i++){
			if(SceneManager.GetActiveScene().name == "World"+i){
				worldIndex = i;  //세계 지수 값을 저장
				CheckLockedLevels(); //잠긴 레벨 확인 
			}
		}
	}

	//버튼 클릭시로드 할 레벨. 레벨 버튼 클릭 이벤트에 사용됩니다.
	public void Selectlevel(string worldLevel){
		SceneManager.LoadScene("Level"+worldLevel); 
	}

	///World1 장면에서 이스케이프를 클릭하면 기본 메뉴 장면을 탐색 할 수있는 경우 아래 코드의 주석 처리를 제거
	/*public void  Update (){
  if (Input.GetKeyDown(KeyCode.Escape) ){
   Application.LoadLevel("MainMenu");
  }   
 }*/


	// 잠긴 레벨을 확인하는 함수
	void  CheckLockedLevels (){
		// 특정 세계의 레벨을 반복
		for(int j = 1; j < LockLevel.levels; j++){
			// 특정 레벨에서 얻은 별의 수를 구하기
			// 개별 레벨 옆에있는 World1 장면에 표시되어야하는 이미지를 사용하는 데 사용
			stars = PlayerPrefs.GetInt("level"+worldIndex.ToString() +":" +j.ToString()+"stars");
			levelIndex = (j+1);
			//별 변수 값에 기초하여 각각의 이미지를 가능하게한다.
			GameObject.Find(j+"star"+stars).GetComponent<Image>().enabled = true;
			Debug.Log(j+"star"+stars);
			//레벨이 잠겨 있는지 확인 
			if((PlayerPrefs.GetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString()))==1){    
				//레벨 버튼을 숨기는 잠금 개체를 비활성화
				GameObject.Find("LockedLevel"+levelIndex).SetActive(false);
			}
		}
	}
}