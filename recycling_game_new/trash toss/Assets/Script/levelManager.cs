using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

	public string scene;

    public void GameOver()
    {
        Application.Quit();
    }

    public void LoadNextScene1()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public static void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public static void LoadPreviousScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex - 1);
    }

	public void LoadMapScene(){
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (2);
	}

	public static void LoadPlayScene(){
		SceneManager.LoadScene (4);
	}

	public static void LoadTitleScene(){
		SceneManager.LoadScene (0);
	}

	public void LoadTitleScene1(){
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (0);
	}

	public static void LoadManualScene(string scene){
		SceneManager.LoadScene (scene);
	}
		
}
