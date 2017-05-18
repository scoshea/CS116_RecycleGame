using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ActivePower : MonoBehaviour {
	public Button act;
	public static int RBP;
	public static float CDtimer = 15;
	//public Color newColor;
	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		if (RBP == 1) {
			act.GetComponent<Image> ().color = new Color32 (244, 66, 66, 255);
			Button lot = act.GetComponent<Button> ();
			lot.onClick.AddListener(test);

		} else if (RBP == 2) {
			act.GetComponent<Image> ().color = new Color32 (66, 66, 244, 255);
			difficultySettings.moveSpeed = 0;
		} else if (RBP == 3) {
			act.GetComponent<Image> ().color = new Color32 (66, 244, 66, 255);
			Button lot = act.GetComponent<Button> ();
			lot.onClick.AddListener(testO);
		}




	}
	void test()
	{
		
		difficultySettings.moveSpeed = 0;
		act.interactable = false;

		}

	void testO()
	{

		difficultySettings.barDropRate = 0;
		act.interactable = false;

	}
	}

