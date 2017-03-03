using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript :MonoBehaviour {
	// Serial is what allows to see on the bar when private
	[SerializeField]
	private float fillAmount = 1;

	[SerializeField]
	private Image content;
	 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HandleBar ();
	}


	private void HandleBar()
	{
		// sets the float to the bar graphic
	
		content.fillAmount = Map(scoreKeeper.score,0,10,0,1);
	}
	private float Map(float score, float inMin,float inMax,float outMin,float outMax)
	{
		// this function will convert 
		return (scoreKeeper.score - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
