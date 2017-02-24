using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour {

	public Slider moneyBar;
	public float startingValue = 1000.0F;
	public float currentValue;

	// Use this for initialization
	void Start () {
		currentValue = startingValue;
	}
	
	// Update is called once per frame
	void Update () {
		currentValue -= 0.5F;
		moneyBar.value = currentValue;
	}

	/*void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "recycle") {
			currentValue += 1;
			moneyBar.value = currentValue;
		} else {
			currentValue -= 0.5F;
			moneyBar.value = currentValue;
		}
	}*/
}
