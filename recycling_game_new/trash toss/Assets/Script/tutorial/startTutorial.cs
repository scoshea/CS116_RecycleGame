using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startTutorial : MonoBehaviour
{	
	public spawnTrash spawnFunc;
	public GameObject trash1;
	public Button startButton;
	public Button completeButton;
	//public Button zbc;


	void Start()
	{
		Button start = startButton.GetComponent<Button>();
		start.onClick.AddListener(startOnClick);
		Button complete = completeButton.GetComponent<Button>();
		complete.onClick.AddListener(completeOnClick);
		//Button test = zbc.GetComponent<Button> ();
		//test.onClick.AddListener (change);
	}

	void Update()
	{
		if (difficultySettings.score == difficultySettings.levelGoal)
		{
			enable(transform.FindChild("Level complete").gameObject);
			enable(completeButton.gameObject);
		}
	}
	void startOnClick()
	{
		difficultySettings.isStarted = true;
		//transform.FindChild("game start").gameObject.SetActive(false);
		disable(startButton.gameObject);
		disable(transform.FindChild("Level Panel").gameObject);
		spawnFunc.spawn();

	}

	void completeOnClick()
	{
		disable(completeButton.gameObject);
		disable(transform.FindChild("Level complete").gameObject);
		levelManager.LoadPreviousScene();
	}

	/*void change()
	{
		difficultySettings.spawnGap = .1f;
	}*/

	private void enable(GameObject obj) { obj.SetActive(true); }
	private void disable(GameObject obj) { obj.SetActive(false); }
}
