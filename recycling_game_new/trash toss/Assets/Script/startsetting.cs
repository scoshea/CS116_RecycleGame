using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startsetting : MonoBehaviour {
    public difficultySettings settings;
	// Use this for initialization
	void Start () {
		settings.setDifficulty(10, 1, .011f, .05f, 10, 2f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
