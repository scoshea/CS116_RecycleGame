using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PowerSel : MonoBehaviour {
	
	public Button Red;
	public Button Blue;
	public Button Green;
	public Button GreyB;
	public Button GreyG;
	public Button GreyR;



	void Start () {

		Button Pwr1 = Red.GetComponent<Button> ();
		Button Pwr2 = Blue.GetComponent<Button> ();
		Button Pwr3 = Green.GetComponent<Button> ();
		Pwr1.onClick.AddListener(SelectRed);
		Pwr2.onClick.AddListener(SelectBlue);
		Pwr3.onClick.AddListener(SelectGreen);
		ActivePower.RBP = 0;


	}
	
	// Update is called once per frame
	void Update () {

	
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
		Debug.Log(ActivePower.RBP);
	
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
		Debug.Log(ActivePower.RBP);
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
		Debug.Log(ActivePower.RBP);
	}
	void SelectGreyR()
	{
		enable (Red.gameObject);
		disable (Blue.gameObject);
		disable (Green.gameObject);

	}

	void SelectGreyB()
	{
		enable (Blue.gameObject);
		disable (Red.gameObject);
		disable (Green.gameObject);
		
	}

	void SelectGreyG()
	{
		enable (Green.gameObject);
		disable (Blue.gameObject);
		disable (Red.gameObject);
		
	}


	private void enable(GameObject obj) { obj.SetActive(true); }
	private void disable(GameObject obj) { obj.SetActive(false); }

}
