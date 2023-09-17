using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultController : MonoBehaviour
{
    public TextMeshProUGUI result;

    void Start()
    {
        result.text = "Your Final Score: " + GameManager.Instance.GetScore() + "\n Level: " + GameManager.Instance.GetLevel() +
            "\n Missions Completed: " + GameManager.Instance.GetCompletedMissions();
    }
}
