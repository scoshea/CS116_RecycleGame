using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binScript_rec : MonoBehaviour {

    public Shader grayscale;
    private Shader defaultShader;
    private bool isDigesting = false;
    private float timer = 0;

    void Start()
    {
        defaultShader = gameObject.GetComponent<Renderer>().material.shader;
    }

    void Update()
    {
        if(isDigesting == true)
        {
            gameObject.GetComponent<Renderer>().material.shader = grayscale;
            timer += Time.deltaTime;
            if(timer >= difficultySettings.digestionTime_rec)
            {
                gameObject.GetComponent<Renderer>().material.shader = defaultShader;
                gameObject.GetComponent<Collider2D>().enabled = true;
                isDigesting = false;
                timer = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "recycle")
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
            isDigesting = true;
        }
    }
}
