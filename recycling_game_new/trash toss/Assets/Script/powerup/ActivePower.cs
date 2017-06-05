using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ActivePower : MonoBehaviour {
	public Button act;
	public static int RBP;
	public static float CDtimer = 5;
	public Button startButton;
	public difficultySettings settings;
	public Button completebutton;
	public static bool greenAdd = false;
	public AudioSource source;
	public AudioClip Spacey;
	public AudioClip ButtonDenial;

	void Start () {



	}

	void Update () {
		if (RBP == 1) {
			act.GetComponent<Image> ().color = new Color32 (244, 66, 66, 255);

			if ( startButton == null){
				Button lot = act.GetComponent<Button> ();
				lot.onClick.AddListener (test);
			
			}
		}  
		else if (RBP == 2) {
			act.GetComponent<Image> ().color = new Color32 (66, 66, 244, 255);
			if (startButton == null) {
				Button lot = act.GetComponent<Button> ();
				lot.onClick.AddListener (test1);

			}

		}   
		else if (RBP == 3) {
			act.GetComponent<Image> ().color = new Color32 (66, 244, 66, 255);
			if (startButton == null) {
				Button lot = act.GetComponent<Button> ();
				lot.onClick.AddListener (testO);
				//needs value set to make inactive next round
			}
		}




	}
	void test()
		{
		// When Freeze is activated
		act.interactable = false;
		if (completebutton != null) {
			
			difficultySettings.moveSpeed = difficultySettings.moveSpeed - difficultySettings.moveSpeed;
			difficultySettings.spawnGap	= CDtimer;
			difficultySettings.barDropRate	= difficultySettings.barDropRate - difficultySettings.barDropRate;
		} 

		}


	void testO(){
		// Bonus Value when called
		act.interactable = false;
		greenAdd = true; 

	}
	void test1()
	{
		//Mystery Power Up?
		act.interactable = false;
		if (binScript_rec.isDigesting == true || binScript_com.isDigesting == true) {
			binScript_com.timer = 10;
			binScript_rec.timer = 10;
		}
	}
		//sound files for Powerup Button
	public void buttonPowerupSound ()
	{
		if (act.interactable == true) {
			if (RBP > 0) {
				source.PlayOneShot (Spacey, 0.5F);
				} 
			else {
				source.PlayOneShot (ButtonDenial, 0.3F);
				}
		} 
		else {
				source.PlayOneShot (ButtonDenial, 0.3F);
		}
	}

}

