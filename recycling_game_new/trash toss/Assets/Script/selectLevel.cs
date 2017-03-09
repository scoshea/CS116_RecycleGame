using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectLevel : MonoBehaviour
{
    public difficultySettings settings;
    public Button level1;


	// Use this for initialization
	void Start ()
    {
        Button lvl1 = level1.GetComponent<Button>();
        lvl1.onClick.AddListener(selectLevel1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void selectLevel1()
    {
        settings.setDifficulty(10, 1, .01f, .05f, 10);
		levelManager.LoadNextScene();
    }
}
