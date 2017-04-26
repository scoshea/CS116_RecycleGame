using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDestroy : MonoBehaviour {

	void OnDestroy()
	{
		destroyDetector.isDestroyed = true;
	}
}
