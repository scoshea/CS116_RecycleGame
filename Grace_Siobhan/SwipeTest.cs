using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour {

	public GameObject player;

	public float maxTime;
	public float minSwipeDist;

	float startTime;
	float endTime;

	Vector3 startPos;
	Vector3 endPos;

	float swipeDistance;
	float swipeTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// if screen was touched at least once, run tests
		if (Input.touchCount > 0) {

			// storing first touch into touch variable
			Touch touch = Input.GetTouch (0); 

			// checking touch phase
			if (touch.Equals(TouchPhase.Began)) {
				
				startTime = Time.time;
				startPos = touch.position;

			} 
			// if touch has ended (lifted finger from device)
			else if (touch.phase == TouchPhase.Ended) {

				endTime = Time.time;
				endPos = touch.position;

				// gives us distance between two points
				swipeDistance = (endPos - startPos).magnitude;
				// gives us duration of swipe
				swipeTime = endTime - startTime;

				// if swipe time and distance are within our boundaries
				if (swipeTime < maxTime && swipeDistance > minSwipeDist) {

					swipe ();

				}
			}
		}

	}

	void swipe(){

		// getting distance between two points
		Vector2 distance = endPos - startPos;

		// check if it's vertical or horizontal swipe
		// if x > y, horizontal swipe
		// if y > x, vertical swipe 
		// we might not need this part because we want to do diagonal swipes too
		if(Mathf.Abs(distance.x) > Mathf.Abs(distance.y)){
			Debug.Log ("Horizontal swipe");

			// checking if it's a left or right swipe
			if (distance.x > 0) {
				Debug.Log ("Right swipe");
			}
			if (distance.x < 0) {
				Debug.Log ("Left swipe");
			}

		} else if(Mathf.Abs(distance.y) > Mathf.Abs(distance.x)){
			Debug.Log ("Vertical swipe");

			// checking if it's an up or down swipe
			if (distance.y > 0) {
				Debug.Log ("Up swipe");

				// accessing objectMove script to make the thing jump
				player.GetComponent<objectMove> ().Jump (); 
			}
			if (distance.y < 0) {
				Debug.Log ("Down swipe");
			}
		
		}
	}
}
