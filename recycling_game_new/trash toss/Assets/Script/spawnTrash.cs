using UnityEngine;
using System.Collections;

public class spawnTrash : MonoBehaviour {

    public GameObject trash_1;
    public GameObject trash_2;
    System.Random rng = new System.Random();

    public void spawn()
    {
        Vector3 spawnSpot = GameObject.Find("spawn spot").transform.position;
        int caseSwitch = rng.Next(1, 2);
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

    // Use this for initialization
    void Start ()
    {
        //spawn();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
