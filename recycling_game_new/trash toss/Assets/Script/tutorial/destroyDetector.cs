using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyDetector : MonoBehaviour {
	
	public static bool isDestroyed;
	public tutorialSpawn spawnFunc;
    private int itemRangeMin;
    private int itemRangeMax;

	// Use this for initialization
	void Start () 
	{
		isDestroyed = false;
        switch (difficultySettings.tutorialLevelCounter)
        {
            case 1:
                itemRangeMin = 0;
                itemRangeMax = 6;
                break;
            case 2:
                itemRangeMin = 7;
                itemRangeMax = 13;
                break;
            case 3:
                itemRangeMin = 14;
                itemRangeMax = 20;
                break;
            case 4:
                itemRangeMin = 21;
                itemRangeMax = 27;
                break;
            case 5:
                itemRangeMin = 28;
                itemRangeMax = 35;
                break;
        }
        //spawnFunc.spawn(kinds);
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (isDestroyed) 
		{
			spawnFunc.spawn (itemRangeMin, itemRangeMax);
			isDestroyed = false;
		}
	}
}
