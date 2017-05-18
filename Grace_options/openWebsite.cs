using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openWebsite : MonoBehaviour {

	public void loadWebsite(){
		Application.OpenURL ("trashtossmobile.com");
		Debug.Log ("website opened");
	}
}
