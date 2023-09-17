using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionController : MonoBehaviour
{
    public float delay;
    public float minMissionTime;
    public float maxMissionTime;

    private float currentMissionTime;
    private float currentTime;
    private bool ready;

    private int missionNumber;

    void Start()
    {
        ready = false;
        missionNumber = GameManager.Instance.GetCompletedMissions();
        StartCoroutine(DelayFirstMission());
    }

    void Update()
    {
        if (ready)
        {
            currentTime += Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CalculateScore();
                currentMissionTime = Random.Range(minMissionTime, maxMissionTime + 1);
                currentTime = 0;
                missionNumber++;
            }
        }
    }

    public int GetMissionNumber()
    {
        return missionNumber;
    }

    public float TimeRemain()
    {
        return currentMissionTime - currentTime;
    }

    private void CalculateScore()
    {
        float diff = Mathf.Abs(TimeRemain());
        int score;
        if (diff < 2)
        {
            score = 1000;
        }
        else
        {
            score = 0;
            GameManager.Instance.DecreaseHealth(500);
        }
        GameManager.Instance.AddScore(score);
    }

    IEnumerator DelayFirstMission()
    {
        yield return new WaitForSeconds(delay);
        ready = true;
        currentMissionTime = Random.Range(minMissionTime, maxMissionTime + 1);
        currentTime = 0;
        missionNumber++;
    }
}
