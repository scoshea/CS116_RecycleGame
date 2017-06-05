using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PowerSel : MonoBehaviour {

	public  Button Red;
	public  Button Blue;
	public  Button Green;
	public  Button GreyB;
	public Button GreyG;
	public  Button GreyR;
	public AudioSource source;
	public AudioClip Plop;

	void Start () {
	ActivePower.RBP = 0;
	
	}

	// Update is called once per frame
	void Update () {
		Button Pwr1 = Red.GetComponent<Button> ();
		Button Pwr2 = Blue.GetComponent<Button> ();
		Button Pwr3 = Green.GetComponent<Button> ();
		Pwr1.onClick.AddListener(SelectRed);
		Pwr2.onClick.AddListener(SelectBlue);
		Pwr3.onClick.AddListener(SelectGreen);
		if (ActivePower.InButtonR == 1) {
			 Red.interactable = false;
			 GreyR.interactable = false;

		} 
		 if (ActivePower.InButtonB == 3) {
			Blue.interactable = false;
			GreyB.interactable = false;
		}

		 if (ActivePower.InButtonG == 2) {
			Green.interactable = false;
			GreyG.interactable = false;
		}
	}

	void SelectRed()
	{

		//difficultySettings.score = 1; // on hold for landfilll limit
		disable(Blue.gameObject);
		disable (Green.gameObject);
		Button Pwr4 = GreyB.GetComponent<Button>();
		Pwr4.onClick.AddListener(SelectGreyB);
		Button Pwr7 = GreyG.GetComponent<Button>();
		Pwr7.onClick.AddListener(SelectGreyG);
		Button PwrG5 = GreyR.GetComponent<Button>();
		PwrG5.onClick.AddListener(SelectGreyR);
		ActivePower.RBP = 1;

		
	}


	void SelectBlue()
	{
		//difficultySettings.moveSpeed = 0;
		disable(Red.gameObject);
		disable (Green.gameObject);
		Button PwrG5 = GreyR.GetComponent<Button>();
		PwrG5.onClick.AddListener(SelectGreyR);
		Button Pwr7 = GreyG.GetComponent<Button>();
		Pwr7.onClick.AddListener(SelectGreyG);
		Button Pwr4 = GreyB.GetComponent<Button>();
		Pwr4.onClick.AddListener(SelectGreyB);
		ActivePower.RBP = 2;

	}
	void SelectGreen()
	{
		//difficultySettings.barDropRate = 0; // on hold for landfilll limit
		disable(Blue.gameObject);
		disable (Red.gameObject);
		Button Pwr6 = GreyB.GetComponent<Button>();
		Pwr6.onClick.AddListener(SelectGreyB);
		Button Pwr8 = GreyR.GetComponent<Button>();
		Pwr8.onClick.AddListener(SelectGreyR);
		Button Pwr7 = GreyG.GetComponent<Button>();
		Pwr7.onClick.AddListener(SelectGreyG);
		ActivePower.RBP = 3;

	}
	void SelectGreyR()
	{
		enable (Red.gameObject);
		disable (Blue.gameObject);
		disable (Green.gameObject);
		ActivePower.RBP = 1;

	}

	void SelectGreyB()
	{
		enable (Blue.gameObject);
		disable (Red.gameObject);
		disable (Green.gameObject);
		ActivePower.RBP = 2;

	}

	void SelectGreyG()
	{
		enable (Green.gameObject);
		disable (Blue.gameObject);
		disable (Red.gameObject);
		ActivePower.RBP = 3;

	}
	// All the Power Up Selction Button Sounds
	public void buttonSound ()
	{
		source.PlayOneShot(Plop, 0.5F);
	}

	private void enable(GameObject obj) { obj.SetActive(true); }
	private void disable(GameObject obj) { obj.SetActive(false); }

}
