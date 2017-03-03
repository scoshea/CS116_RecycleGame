using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startGame : MonoBehaviour
{

    public spawnTrash spawnFunc;
    public Button startbutton;

    void Start()
    {
        Button btn = startbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        difficultySettings.isStarted = true;
        spawnFunc.spawn();
        transform.FindChild("game start").gameObject.SetActive(false);
    }
}
