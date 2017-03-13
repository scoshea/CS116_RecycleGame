using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binScript_com : MonoBehaviour {

    private bool isDigesting = false;
    private float timer = 0;

    private void Update()
    {
        if (isDigesting == true)
        {
            timer += Time.deltaTime;
            if (timer >= difficultySettings.digestionTime_com)
            {
                gameObject.GetComponent<Collider2D>().enabled = true;
                isDigesting = false;
                timer = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "composite")
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
            isDigesting = true;
        }
    }
}
