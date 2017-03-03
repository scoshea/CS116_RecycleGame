using UnityEngine;
using System.Collections;


public class scoreKeeper : MonoBehaviour {

    public static int score;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        if (score == 10)
        {
            levelManager.LoadNextScene();
        }
    }
}
