using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyDetector : MonoBehaviour {
	
	public static bool isDestroyed;
	public tutorialSpawn spawnFunc;
    private int kinds;

	// Use this for initialization
	void Start () 
	{
		isDestroyed = false;
        switch (difficultySettings.tutorialLevelCounter)
        {
            case 1:
                kinds = 3;
                break;
            case 2:
                kinds = 6;
                break;
            case 3:
                kinds = 9;
                break;
            case 4:
                kinds = 11;
                break;
            case 5:
                kinds = 13;
                break;
        }
        spawnFunc.spawn(kinds);
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (isDestroyed) 
		{
			spawnFunc.spawn (kinds);
			isDestroyed = false;
		}
	}
}
