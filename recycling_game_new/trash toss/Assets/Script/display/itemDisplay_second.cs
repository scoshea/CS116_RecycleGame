using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itemDisplay_second : MonoBehaviour {

	public Sprite trash1;
	public Sprite trash2;

	Image image;

	// Use this for initialization
	void Start()
	{
		image = GetComponent<Image>();
		switch (tips.tipsSlot2) {
		case 1:
			image.sprite = trash1;
			break;
		case 2:
			image.sprite = trash2;
			break;
		default:
			image.sprite = trash1;
			break;
		}
	}

	// Update is called once per frame
	void Update()
	{
	}
}
