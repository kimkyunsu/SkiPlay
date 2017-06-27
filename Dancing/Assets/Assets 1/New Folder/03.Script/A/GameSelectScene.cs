using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSelectScene : MonoBehaviour {

	public void NormalSelect()
	{
		SceneManager.LoadScene ("World1");
	}

	public void illusion()
	{
		SceneManager.LoadScene ("World2");
	}

    public void Escape()
    {
        SceneManager.LoadScene("World3");
    }

    public void CubeMode()
    {
        SceneManager.LoadScene("World4");
    }
    
}
