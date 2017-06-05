using UnityEngine;
using System.Collections;

public class spawnTrash : MonoBehaviour {

    public GameObject trashItems;

    System.Random trashType = new System.Random();
    System.Random offset = new System.Random();
    private float xOffset;

    public void spawn()
    {
        Vector3 spot = GameObject.Find("spawn spot").transform.position;
		xOffset = 0f; // + (float)offset.NextDouble() * 4;
        Vector3 spawnSpot = spot + new Vector3(xOffset, 2, 0);

        int caseSwitch = trashType.Next(1, trashItems.transform.childCount+1);
        Instantiate(trashItems.transform.GetChild(caseSwitch), spawnSpot, transform.rotation);
    }

    
	void Update(){
		/*
		print ("game start:    gainRate: " + difficultySettings.barGainRate +
		"    dropRate" + difficultySettings.barDropRate +
		"    speed: " + difficultySettings.moveSpeed +
		"    gap: " + difficultySettings.spawnGap +
			"	isstarted: " + difficultySettings.isStarted + "" +
			"	iscompleted: " + difficultySettings.isCompleted);
			*/
	}
}
