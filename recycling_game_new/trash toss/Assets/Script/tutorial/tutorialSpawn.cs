using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialSpawn : MonoBehaviour
{
    public GameObject trash_1;
    public GameObject trash_2;
    public GameObject trash_3;
    public GameObject trash_4;
    public GameObject trash_5;
    public GameObject trash_6;
    public GameObject trash_7;
    public GameObject trash_8;
    public GameObject trash_9;
    public GameObject trash_10;
    public GameObject trash_11;
    public GameObject trash_12;
    public GameObject trash_13;

    System.Random trashType = new System.Random();

    public void spawn(int kind)
    {
        Vector3 spawnSpot = GameObject.Find("spawn spot").transform.position;
        int caseSwitch = trashType.Next(1, kind);
        switch (caseSwitch)
        {
            case 1:
                Instantiate(trash_1, spawnSpot, transform.rotation);
                break;
            case 2:
                Instantiate(trash_2, spawnSpot, transform.rotation);
                break;
            case 3:
                Instantiate(trash_3, spawnSpot, transform.rotation);
                break;
            case 4:
                Instantiate(trash_4, spawnSpot, transform.rotation);
                break;
            case 5:
                Instantiate(trash_5, spawnSpot, transform.rotation);
                break;
            case 6:
                Instantiate(trash_6, spawnSpot, transform.rotation);
                break;
            case 7:
                Instantiate(trash_7, spawnSpot, transform.rotation);
                break;
            case 8:
                Instantiate(trash_8, spawnSpot, transform.rotation);
                break;
            case 9:
                Instantiate(trash_9, spawnSpot, transform.rotation);
                break;
            case 10:
                Instantiate(trash_10, spawnSpot, transform.rotation);
                break;
            case 11:
                Instantiate(trash_11, spawnSpot, transform.rotation);
                break;
            case 12:
                Instantiate(trash_12, spawnSpot, transform.rotation);
                break;
            case 13:
                Instantiate(trash_13, spawnSpot, transform.rotation);
                break;
            default:
                Instantiate(trash_1, spawnSpot, transform.rotation);
                break;

        }
    }
}