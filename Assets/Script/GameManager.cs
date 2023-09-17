using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int startHealth;
    public int levelIncrement;

    public float maxDuration;
    public float minDuration;

    public float startMaxGap;
    public float startMinGap;
    public float endMaxGap;
    public float endMinGap;

    private int health;
    private int score;
    private int level;

    private int pointsToNext;
    private int nextLevelScore;

    private float currentDuration;
    private float currentMaxGap;
    private float currentMinGap;

    private int completedMissions;
    private int coins;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        coins = 0;
        completedMissions = 0;
        Reset();
    }

    void Update()
    {
        //Debug.Log(score);
        if (score >= nextLevelScore)
        {
            UpdateLevel();
        }
    }

    public void IncreaseHealth(int change)
    {
        health += change;
        health = Mathf.Min(health, startHealth);
    }

    public void DecreaseHealth(int change)
    {
        health -= change;
        if (health <= 0)
        {
            StoreCompletedMissions();
            SceneManager.LoadScene("End Screen");
            //Debug.Log("die");
            
        }
    }

    public void AddScore(int change)
    {
        score += change;
        coins += change / 50;
    }

    public int GetHealth()
    {
        return health;
    }

    public int GetScore()
    {
        return score;
    }

    public int GetLevel()
    {
        return level;
    }

    public int GetNextLevelScore()
    {
        return nextLevelScore;
    }

    public void StoreCompletedMissions()
    {
        completedMissions = Mathf.Max(0, FindObjectOfType<MissionController>().GetMissionNumber() - 1);
    }

    public int GetCompletedMissions()
    {
        return completedMissions;
    }

    public void UseCoins(int amount)
    {
        coins -= amount;
    }

    public int GetCoins()
    {
        return coins;
    }

    public void Reset()
    {
        health = startHealth;
        score = 0;
        level = 1;

        pointsToNext = levelIncrement;
        nextLevelScore = pointsToNext;

        currentDuration = maxDuration;
        currentMaxGap = startMaxGap;
        currentMinGap = startMinGap;
    }

    private void UpdateLevel()
    {
        level++;
        pointsToNext += levelIncrement;
        nextLevelScore += pointsToNext;
        if (level % 5 == 0)
        {
            currentDuration = Mathf.Max(minDuration, currentDuration - 0.1f);
            currentMaxGap = Mathf.Max(endMaxGap, currentMaxGap - 0.1f);
            currentMinGap = Mathf.Max(endMinGap, currentMinGap - 0.1f);
            SetDifficulty();
        }
        FindObjectOfType<InformationDisplay>().DisplayLevel();
        Debug.Log("Score: " + score + " Level: " + level + " Duration: " + currentDuration + " Min Gap: " + currentMinGap + " Max Gap: " + currentMaxGap);
    }

    private void SetDifficulty()
    {
        SpawnController spawnController = FindObjectOfType<SpawnController>();
        spawnController.SetTimes(currentDuration, currentMinGap, currentMaxGap);
    }
}
