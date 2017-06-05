using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CDPT : MonoBehaviour {
	public Button act;
	public Button completebutton;
	public  float store =0f;
	float gap =0f;
	float delaybar = 0f;
	public int prevlevel;
	// Use this for initialization
	void Start () {
	store = difficultySettings.moveSpeed;
	gap = difficultySettings.spawnGap;
	delaybar = difficultySettings.barDropRate;
	prevlevel = difficultySettings.levelCounter;
	}

	// Update is called once per frame
	void Update () {

		if ( act.interactable == false ) {
			// begins timer when ActivePower is in motion
			ActivePower.CDtimer -= Time.deltaTime;

			if (ActivePower.CDtimer <= 0) {
				difficultySettings.moveSpeed = store;
				difficultySettings.spawnGap = gap;
				difficultySettings.barDropRate = delaybar;
				print ("i made it");
				if (completebutton == null) {
					//reset counter for next game when freeze is active
					ActivePower.CDtimer = 5;
					difficultySettings.moveSpeed = store;


				}

			} 

			else if( prevlevel < difficultySettings.levelCounter){
				difficultySettings.moveSpeed = store;
				difficultySettings.spawnGap = gap;
				difficultySettings.barDropRate = delaybar;
			 }
		}
	}
}

