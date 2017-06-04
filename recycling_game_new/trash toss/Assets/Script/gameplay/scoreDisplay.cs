using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreDisplay : MonoBehaviour {

    Text text;
    private int limit;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        limit = difficultySettings.landfillLimit - difficultySettings.landfillCounter;
        text.text =  limit.ToString();
    }
}
