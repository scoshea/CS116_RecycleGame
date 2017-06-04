using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class failedItem2 : MonoBehaviour
{

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
    public Sprite blank;

    Image image;

    // Use this for initialization
    void Start()
    {
        if (difficultySettings.failedRecord[1] != null)
        {
            image = GetComponent<Image>();
            switch (difficultySettings.failedRecord[1])
            {
                case "apple":
                    image.sprite = trash1;
                    break;
                case "banana":
                    image.sprite = trash2;
                    break;
                case "chips":
                    image.sprite = trash3;
                    break;
                case "juice":
                    image.sprite = trash4;
                    break;
                case "battery (small)":
                    image.sprite = trash5;
                    break;
                case "bottle":
                    image.sprite = trash6;
                    break;
                case "box":
                    image.sprite = trash7;
                    break;
                case "envelope":
                    image.sprite = trash8;
                    break;
                case "glass":
                    image.sprite = trash9;
                    break;
                case "ketchup":
                    image.sprite = trash10;
                    break;
                case "milk":
                    image.sprite = trash11;
                    break;
                case "newspaper":
                    image.sprite = trash12;
                    break;
                case "soda":
                    image.sprite = trash13;
                    break;
                default:
                    image.sprite = blank;
                    break;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
