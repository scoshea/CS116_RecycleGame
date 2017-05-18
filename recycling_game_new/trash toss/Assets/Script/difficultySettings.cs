using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficultySettings : MonoBehaviour {
    public static float timer;
    public static bool isStarted;
    public static bool isCompleted;
    public static int score;
    public static int landfillCounter;
    public static float barGainRate;
    public static float barDropRate;
    public static float moveSpeed;
    public static int levelGoal;
    public static int landfillLimit;
    public static float spawnGap;
    public static float digestionTime_rec;
    public static float digestionTime_com;
	public static List<string> playRecord;
	public static List<string> failedRecord;
	public static int levelCounter = 1;

    // Use this for initialization
    void Start ()
    {
        isStarted = false;
        isCompleted = false;
        score = 0;
        landfillCounter = 1;
		playRecord = new List<string> ();
		failedRecord = new List<string> ();
        //setDifficulty(10, 1, .01f, .05f, 10);
        print("game start: level goal: " + levelGoal + "    gainRate: " + barGainRate + "    dropRate" + barDropRate
            + "    speed: " + moveSpeed + "    limit: " + landfillLimit);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isStarted)
            timer += Time.deltaTime;
        //print(timer);


        //lever goal
        if (score == levelGoal)
            isCompleted = true;
        

        //game over
		if (landfillCounter == landfillLimit)
			levelManager.LoadTitleScene ();
	}

    public void setDifficulty(int goal, float gain, float drop, float speed, int limit, float gap)
    {
        setGoal(goal);
        setGainRate(gain);
        setDropRate(drop);
        setSpeed(speed);
        setLimit(limit);
        setSpawnGap(gap);
    }

    private void setGoal(int goal) { levelGoal = goal; }
    private void setGainRate(float rate) { barGainRate = rate; }
    private void setDropRate(float rate) { barDropRate = rate; }
    private void setSpeed(float speed) { moveSpeed = speed; }
    private void setLimit(int limit) { landfillLimit = limit; }
    private void setSpawnGap(float gap) { spawnGap = gap; }

}
