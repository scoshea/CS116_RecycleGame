using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tips : MonoBehaviour {

	public static int tipsSlot1;
	public static int tipsSlot2;
	System.Random random = new System.Random();

	// Use this for initialization
	void Start () {
		tipsSlot1 = random.Next(1, 3);
		tipsSlot2 = random.Next(1, 3);

	}


	// Update is called once per frame
	void Update () {
		
	}
}
