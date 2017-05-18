using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startGame : MonoBehaviour
{
    public Button startButton;
    public Button completeButton;
	public Animator ani;
	public float dropRate;
	public float speed;
	public float gap;
	public int limit;
	//public Button zbc;
	System.Random type = new System.Random();

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
			ani.enabled = false;
            enable(completeButton.gameObject);
        }
    }
    void startOnClick()
    {
        difficultySettings.isStarted = true;
        //transform.FindChild("game start").gameObject.SetActive(false);
        disable(startButton.gameObject);
		disable(transform.FindChild("Level Panel").gameObject);
    }

    void completeOnClick()
    {
		difficultySettings.levelGoal += 5;
		changeDifficulties ();
		difficultySettings.levelCounter++;
        disable(completeButton.gameObject);
        disable(transform.FindChild("Level complete").gameObject);
        levelManager.LoadPlayScene();
    }

	/*void change()
	{
		difficultySettings.spawnGap = .1f;
	}*/

    private void enable(GameObject obj) { obj.SetActive(true); }
    private void disable(GameObject obj) { obj.SetActive(false); }
	private void changeDifficulties()
	{
		int caseswitch = type.Next (1, 4);
		switch(caseswitch)
		{
		case 1:
			difficultySettings.barDropRate = difficultySettings.barDropRate * dropRate;
			break;
		case 2:
			difficultySettings.moveSpeed = difficultySettings.moveSpeed * speed;
			break;
		case 3:
			difficultySettings.spawnGap = difficultySettings.spawnGap * gap;
			break;
		case 4:
			difficultySettings.landfillLimit -= limit;
			break;
		}
	}
}
