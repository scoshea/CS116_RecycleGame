using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itemCategory : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>();
		switch (tips.tipsSlot1){
            case 1:
                text.text = "--compost";
                break;
            case 2:
                text.text = "--compost";
                break;
            case 3:
                text.text = "--landfill";
                break;
            case 4:
                text.text = "--landfill";
                break;
            case 5:
                text.text = "--other";
                break;
            case 6:
                text.text = "--recycle";
                break;
            case 7:
                text.text = "--recycle";
                break;
            case 8:
                text.text = "--recycle";
                break;
            case 9:
                text.text = "--recycle";
                break;
            case 10:
                text.text = "--recycle";
                break;
            case 11:
                text.text = "--recycle";
                break;
            case 12:
                text.text = "--recycle";
                break;
            case 13:
                text.text = "--recycle";
                break;
        }
	}

	// Update is called once per frame
	void Update()
	{
	}
}
