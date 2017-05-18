using UnityEngine;
using System.Collections;

public class spawnTrash : MonoBehaviour {

    public GameObject trash_1;
    public GameObject trash_2;
	public GameObject trash_3;
	public GameObject trash_4;
	public GameObject trash_5;
	public GameObject trash_6;
	public GameObject trash_7;
    System.Random trashType = new System.Random();
    System.Random offset = new System.Random();
    private float xOffset;

    public void spawn()
    {
        Vector3 spot = GameObject.Find("spawn spot").transform.position;
		xOffset = 0f; // + (float)offset.NextDouble() * 4;
        Vector3 spawnSpot = spot + new Vector3(xOffset, 2, 0);
        int caseSwitch = trashType.Next(1, 8);
        switch (caseSwitch)
        {
            case 1:
                Instantiate(trash_1, spawnSpot, transform.rotation);
                break;
            case 2:
                Instantiate(trash_2, spawnSpot, transform.rotation);
                break;
			case 3:
				Instantiate (trash_3, spawnSpot, transform.rotation);
				break;
			case 4:
				Instantiate (trash_4, spawnSpot, transform.rotation);
				break;
			case 5:
				Instantiate (trash_5, spawnSpot, transform.rotation);
				break;
			case 6:
				Instantiate (trash_6, spawnSpot, transform.rotation);
				break;
			case 7:
				Instantiate (trash_7, spawnSpot, transform.rotation);
				break;
            default:
                Instantiate(trash_1, spawnSpot, transform.rotation);
                break;

        }
    }
}
