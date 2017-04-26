using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDPT : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ActivePower.CDtimer -= Time.deltaTime;
		if (ActivePower.CDtimer <= 0) {
			difficultySettings.moveSpeed = .05f;
			difficultySettings.barDropRate = .01f;
		}
	}
}
