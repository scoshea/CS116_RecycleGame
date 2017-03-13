using UnityEngine;
using System.Collections;

public class spawnTrash : MonoBehaviour {

    public GameObject trash_1;
    public GameObject trash_2;
    System.Random trashType = new System.Random();
    System.Random offset = new System.Random();
    private float xOffset;

    public void spawn()
    {
        Vector3 spot = GameObject.Find("spawn spot").transform.position;
        xOffset = -2f + (float)offset.NextDouble() * 4;
        Vector3 spawnSpot = spot + new Vector3(xOffset, 0, 0);
        int caseSwitch = trashType.Next(1, 3);
        switch (caseSwitch)
        {
            case 1:
                Instantiate(trash_1, spawnSpot, transform.rotation);
                break;
            case 2:
                Instantiate(trash_2, spawnSpot, transform.rotation);
                break;
            default:
                Instantiate(trash_1, spawnSpot, transform.rotation);
                break;

        }
    }
}
