using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startGame : MonoBehaviour
{
    public Button startbutton;

    void Start()
    {
        Button btn = startbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        difficultySettings.isStarted = true;
        transform.FindChild("game start").gameObject.SetActive(false);
		transform.FindChild ("Level Panel").gameObject.SetActive (false);
    }
}
