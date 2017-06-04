using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itemDisplay_second : MonoBehaviour {

    public Sprite trash1;
    public Sprite trash2;
    public Sprite trash3;
    public Sprite trash4;
    public Sprite trash5;
    public Sprite trash6;
    public Sprite trash7;
    public Sprite trash8;
    public Sprite trash9;
    public Sprite trash10;
    public Sprite trash11;
    public Sprite trash12;
    public Sprite trash13;

    Image image;

    // Use this for initialization
    void Start()
    {
        image = GetComponent<Image>();
        switch (tips.tipsSlot2)
        {
            case 1:
                image.sprite = trash1;
                break;
            case 2:
                image.sprite = trash2;
                break;
            case 3:
                image.sprite = trash3;
                break;
            case 4:
                image.sprite = trash4;
                break;
            case 5:
                image.sprite = trash5;
                break;
            case 6:
                image.sprite = trash6;
                break;
            case 7:
                image.sprite = trash7;
                break;
            case 8:
                image.sprite = trash8;
                break;
            case 9:
                image.sprite = trash9;
                break;
            case 10:
                image.sprite = trash10;
                break;
            case 11:
                image.sprite = trash11;
                break;
            case 12:
                image.sprite = trash12;
                break;
            case 13:
                image.sprite = trash13;
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
