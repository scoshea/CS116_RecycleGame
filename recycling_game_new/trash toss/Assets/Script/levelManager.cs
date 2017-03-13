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

	public void LoadDiffScene(){
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex + 2);
	}

	public void LoadManualScene(string scene){
		SceneManager.LoadScene (scene);
	}
}
