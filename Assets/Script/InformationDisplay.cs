using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformationDisplay : MonoBehaviour
{
    public GameObject score;
    public GameObject missionNumber;
    public GameObject missionTime;
    public GameObject level;

    private MissionController missionController;

    private byte r;
    private byte g;
    private byte b;

    void Start()
    {
        missionController = FindObjectOfType<MissionController>();
        TextMeshProUGUI levelText = level.GetComponent<TextMeshProUGUI>();
        r = (byte) (levelText.color.r * 255);
        g = (byte) (levelText.color.g * 255);
        b = (byte) (levelText.color.b * 255);
        levelText.color = new Color32(r, g, b, 0);
    }

    void Update()
    {
        score.GetComponent<TextMeshProUGUI>().text = "Score: " + GameManager.Instance.GetScore();
        missionNumber.GetComponent<TextMeshProUGUI>().text = "Current mission: #" + missionController.GetMissionNumber();
        missionTime.GetComponent<TextMeshProUGUI>().text = "Time remaining: " + ((int) missionController.TimeRemain());
    }

    public void DisplayLevel()
    {
        StartCoroutine(ShowLevel());
    }

    IEnumerator ShowLevel()
    {
        TextMeshProUGUI levelText = level.GetComponent<TextMeshProUGUI>();
        levelText.text = "Level " + GameManager.Instance.GetLevel();
        levelText.color = new Color32(r, g, b, 255);
        yield return new WaitForSeconds(5);
        levelText.color = new Color32(r, g, 100, 0);
    }
}
