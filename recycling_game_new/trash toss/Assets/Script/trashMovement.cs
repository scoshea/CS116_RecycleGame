using UnityEngine;
using System.Collections;

public class trashMovement : MonoBehaviour {
    public GameObject trash;
    public float speed = .05f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        trash.transform.Translate(Vector3.down * speed);
	}
}
