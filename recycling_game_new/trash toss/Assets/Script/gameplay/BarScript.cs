using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript :MonoBehaviour {
    // Serial is what allows to see on the bar when private



	[SerializeField]
	private Image content;
	int score = difficultySettings.score;
	// Use this for initialization
	void Start () {
		content.fillAmount = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		if(difficultySettings.isStarted & !difficultySettings.isCompleted){
			content.fillAmount -= Time.deltaTime * difficultySettings.barDropRate;
			if (score != difficultySettings.score) {
				content.fillAmount = content.fillAmount + difficultySettings.barGainRate;
				score = difficultySettings.score;
			}
			if (ActivePower.greenAdd) {
				content.fillAmount = content.fillAmount + .3f;
				ActivePower.greenAdd = false;

			 }
			}
	}



}
