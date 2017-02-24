using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour {

	public Slider moneyBar;
	public static float startingValue = 50.0F;
	public static float currentValue;


	// Use this for initialization
	void Start () {
		currentValue = startingValue;
	}
	
	// Update is called once per frame
	void Update () {
		currentValue -= 0.05F;
		//moneyBar.value = currentValue;
		/*if (scoreKeeper.score > 0) {
			currentValue = scoreKeeper.score;
			moneyBar.value = currentValue;
			
		}*/
		moneyBar.value = currentValue;
	}
		
}
