using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherButton : MonoBehaviour {

	GameObject[] gameObjects = new GameObject[10];

	// code from: http://answers.unity3d.com/questions/314503/destroy-all-objects-with-tag-enemy.html
	public void DestroyAllObjects()
	{
		gameObjects = GameObject.FindGameObjectsWithTag ("other");

		for(int i = 0 ; i < gameObjects.Length ; i ++)
		{
			Destroy(gameObjects[i]);
			difficultySettings.score += 1;
		}
	}
}
