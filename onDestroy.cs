using UnityEngine;
using System.Collections;

public class onDestroy : MonoBehaviour {
    public spawnTrash spawnFunc;

    void OnDestroy()
    {
        spawnFunc.spawn();
    }
}
