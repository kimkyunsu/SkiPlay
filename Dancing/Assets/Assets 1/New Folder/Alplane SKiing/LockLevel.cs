using UnityEngine;
using System.Collections;

public class LockLevel : MonoBehaviour {


	public static int worlds = 1; //세계의 수
	public static int levels = 10; //단계의 수

	private int worldIndex;   
	private int levelIndex;   


	void  Start (){
		PlayerPrefs.DeleteAll(); // 시작시 데이터 지우기
		LockLevels();   //함수 LockLevels를 호출
	}

	//레벨을 잠그는 기능
	void  LockLevels (){
		//모든 세계의 모든 단계를 반복
		for (int i = 0; i < worlds; i++){
			for (int j = 1; j < levels; j++){
				worldIndex  = (i+1);
				levelIndex  = (j+1);
				//그 특정 레벨과 월드의 PlayerPrefs를 만들고 그 이름의 키가 없다면 0으로 설정
				if(!PlayerPrefs.HasKey("level"+worldIndex.ToString() +":" +levelIndex.ToString())){
					PlayerPrefs.SetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString(),0);
				}

			}
		}

	}
}