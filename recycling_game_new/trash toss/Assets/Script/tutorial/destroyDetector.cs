using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyDetector : MonoBehaviour {
	
	public static bool isDestroyed;
	public spawnTrash spawnFunc;

	// Use this for initialization
	void Start () 
	{
		isDestroyed = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isDestroyed) 
		{
			spawnFunc.spawn ();
			isDestroyed = false;
		}
	}
}
