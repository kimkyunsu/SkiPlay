using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SettingManagement : MonoBehaviour {


	public GameObject MainMenu;

	void Start()
	{
		Screen.SetResolution (800, 1200, true);
	}

    public void TogglePauseMenu ()
	{
		MainMenu.SetActive (!MainMenu.activeSelf);
        if (Time.timeScale == 1)//시간 정지 by이천국
        {
            Time.timeScale = 0;
        }else
        {
            Time.timeScale = 1;
        }
	}

    public void RePlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //현재 씬을 다시 부르기
        Time.timeScale = 1;
    }
    public void NextStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //빌드셋팅에 등록한 자기 씬번호의 다음을 부르기
    }

    public void ToMenu ()
	{
        SceneManager.LoadScene("MainMenu");
	}

    public void ToStageSelect ()
	{
        SceneManager.LoadScene("World1");
	}
	public void illusionStageSelect()
	{
		SceneManager.LoadScene("World2");
	}
    public void EscapeStageSelect()
    {
        SceneManager.LoadScene("World3");
    }
    public void CubeStageSelect()
    {
        SceneManager.LoadScene("World4");
    }

    public void ToReplay1()
    {
        SceneManager.LoadScene("Level1.1");
        Time.timeScale = 1;
    }
    public void NextStageClick2()
    {
        SceneManager.LoadScene("Level1.2");
    }
    public void ToReplay2 ()
	{
		SceneManager.LoadScene("Level1.2");
		Time.timeScale = 1;
	}
	public void NextStageClick3()
	{
		SceneManager.LoadScene("Level1.3");
	}

	public void ToReplay3 ()
	{
		SceneManager.LoadScene("Level1.3");
		Time.timeScale = 1;
	}
	public void NextStageClick4()
	{
		SceneManager.LoadScene("Level1.4");
	}

	public void ToReplay4 ()
	{
		SceneManager.LoadScene("Level1.4");
		Time.timeScale = 1;
	}
	public void NextStageClick5()
	{
		SceneManager.LoadScene("Level1.5");
	}

	public void ToReplay5 ()
	{
		SceneManager.LoadScene("Level1.5");
		Time.timeScale = 1;
	}
	public void NextStageClick6()
	{
		SceneManager.LoadScene("Level1.6");
	}

	public void ToReplay6 ()
	{
		SceneManager.LoadScene("Level1.6");
		Time.timeScale = 1;
	}
	public void NextStageClick7()
	{
		SceneManager.LoadScene("Level1.7");
	}

	public void ToReplay7 ()
	{
		SceneManager.LoadScene("Level1.7");
		Time.timeScale = 1;
	}
	public void NextStageClick8()
	{
		SceneManager.LoadScene("Level1.8");
	}

	public void ToReplay8 ()
	{
		SceneManager.LoadScene("Level1.8");
		Time.timeScale = 1;
	}
	public void NextStageClick9()
	{
		SceneManager.LoadScene("Level1.9");
	}

	public void ToReplay9 ()
	{
		SceneManager.LoadScene("Level1.9");
		Time.timeScale = 1;
	}
	public void NextStageClick10()
	{
		SceneManager.LoadScene("Level1.10");
	}

	public void ToReplay10 ()
	{
		SceneManager.LoadScene("Level1.10");
		Time.timeScale = 1;
	}
	public void NextStageClick11()
	{
		SceneManager.LoadScene("Level1.11");
	}

	public void ToReplay11 ()
	{
		SceneManager.LoadScene("Level1.11");
		Time.timeScale = 1;
	}
	public void NextStageClick12()
	{
		SceneManager.LoadScene("Level1.12");
	}

	public void ToReplay12 ()
	{
		SceneManager.LoadScene("Level1.12");
		Time.timeScale = 1;
	}
	public void NextStageClick13()
	{
		SceneManager.LoadScene("Level1.13");
	}
		

	public void ToReplay13 ()
	{
		SceneManager.LoadScene("Level1.13");
		Time.timeScale = 1;
	}
	public void NextStageClick14()
	{
		SceneManager.LoadScene("Level1.14");
	}

	public void ToReplay14 ()
	{
		SceneManager.LoadScene("Level1.14");
		Time.timeScale = 1;
	}
	public void NextStageClick15()
	{
		SceneManager.LoadScene("Level1.15");
	}

	public void ToReplay15 ()
	{
		SceneManager.LoadScene("Level1.15");
		Time.timeScale = 1;
	}
	public void NextStageClick16()
	{
		SceneManager.LoadScene("Level1.16");
	}

	public void ToReplay16 ()
	{
		SceneManager.LoadScene("Level1.16");
		Time.timeScale = 1;
	}
	public void NextStageClick17()
	{
		SceneManager.LoadScene("Level1.17");
	}

	public void ToReplay17 ()
	{
		SceneManager.LoadScene("Level1.17");
		Time.timeScale = 1;
	}
	public void NextStageClick18()
	{
		SceneManager.LoadScene("Level1.18");
	}

	public void ToReplay18 ()
	{
		SceneManager.LoadScene("Level1.18");
		Time.timeScale = 1;
	}
	public void NextStageClick19()
	{
		SceneManager.LoadScene("Level1.19");
	}

	public void ToReplay19 ()
	{
		SceneManager.LoadScene("Level1.19");
		Time.timeScale = 1;
	}
	public void NextStageClick20()
	{
		SceneManager.LoadScene("Level1.20");
	}

	public void ToReplay20 ()
	{
		SceneManager.LoadScene("Level1.20");
		Time.timeScale = 1;
	}
	public void NextStageClick21()
	{
		SceneManager.LoadScene("Level1.21");
	}

	public void ToReplay21 ()
	{
		SceneManager.LoadScene("Level1.21");
		Time.timeScale = 1;
	}
	public void NextStageClick22()
	{
		SceneManager.LoadScene("Level1.22");
	}

	public void ToReplay22 ()
	{
		SceneManager.LoadScene("Level1.22");
		Time.timeScale = 1;
	}
	public void NextStageClick23()
	{
		SceneManager.LoadScene("Level1.23");
	}

	public void ToReplay23 ()
	{
		SceneManager.LoadScene("Level1.23");
		Time.timeScale = 1;
	}
	public void NextStageClick24()
	{
		SceneManager.LoadScene("Level1.24");
	}

	public void ToReplay24 ()
	{
		SceneManager.LoadScene("Level1.24");
		Time.timeScale = 1;
	}
	public void NextStageClick25()
	{
		SceneManager.LoadScene("Level1.25");
	}

	public void ToReplay25 ()
	{
		SceneManager.LoadScene("Level1.25");
		Time.timeScale = 1;
	}
	public void NextStageClick26()
	{
		SceneManager.LoadScene("Level1.26");
	}

	public void ToReplay26 ()
	{
		SceneManager.LoadScene("Level1.26");
		Time.timeScale = 1;
	}
	public void NextStageClick27()
	{
		SceneManager.LoadScene("Level1.27");
	}

	public void ToReplay27 ()
	{
		SceneManager.LoadScene("Level1.27");
		Time.timeScale = 1;
	}
	public void NextStageClick28()
	{
		SceneManager.LoadScene("Level1.28");
	}

	public void ToReplay28 ()
	{
		SceneManager.LoadScene("Level1.28");
		Time.timeScale = 1;
	}
	public void NextStageClick29()
	{
		SceneManager.LoadScene("Level1.29");
	}

	public void ToReplay29 ()
	{
		SceneManager.LoadScene("Level1.29");
		Time.timeScale = 1;
	}
	public void NextStageClick30()
	{
		SceneManager.LoadScene("Level1.30");
	}

	public void ToReplay30 ()
	{
		SceneManager.LoadScene("Level1.30");
		Time.timeScale = 1;
	}
	public void NextStageClick31()
	{
		SceneManager.LoadScene("Level1.31");
	}
		
	public void ToReplay31 ()
	{
		SceneManager.LoadScene("Level1.31");
		Time.timeScale = 1;
	}
	public void NextStageClick32()
	{
		SceneManager.LoadScene("Level1.32");
	}
	public void ToReplay32 ()
	{
		SceneManager.LoadScene("Level1.32");
		Time.timeScale = 1;
	}
	public void NextStageClick33()
	{
		SceneManager.LoadScene("Level1.33");
	}

	public void ToReplay33 ()
	{
		SceneManager.LoadScene("Level1.33");
		Time.timeScale = 1;
	}
	public void NextStageClick34()
	{
		SceneManager.LoadScene("Level1.34");
	}

	public void ToReplay34 ()
	{
		SceneManager.LoadScene("Level1.34");
		Time.timeScale = 1;
	}
	public void NextStageClick35()
	{
		SceneManager.LoadScene("Level1.35");
	}

	public void ToReplay35 ()
	{
		SceneManager.LoadScene("Level1.35");
		Time.timeScale = 1;
	}
	public void NextStageClick36()
	{
		SceneManager.LoadScene("Level1.36");
	}

	public void ToReplay36 ()
	{
		SceneManager.LoadScene("Level1.36");
		Time.timeScale = 1;
	}
	public void NextStageClick37()
	{
		SceneManager.LoadScene("Level1.37");
	}

	public void ToReplay37 ()
	{
		SceneManager.LoadScene("Level1.27");
		Time.timeScale = 1;
	}
	public void NextStageClick38()
	{
		SceneManager.LoadScene("Level1.38");
	}

	public void ToReplay38 ()
	{
		SceneManager.LoadScene("Level1.38");
		Time.timeScale = 1;
	}
	public void NextStageClick39()
	{
		SceneManager.LoadScene("Level1.39");
	}

	public void ToReplay39 ()
	{
		SceneManager.LoadScene("Level1.39");
		Time.timeScale = 1;
	}
	public void NextStageClick40()
	{
		SceneManager.LoadScene("Level1.40");
	}
	public void ToReplay40 ()
	{
		SceneManager.LoadScene("Level1.40");
		Time.timeScale = 1;
	}
}
