using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CathcartController : MonoBehaviour
{
    public TextMeshProUGUI quote;

    void Start()
    {
        quote.text = "You did not meet the " + (GameManager.Instance.GetCompletedMissions() + 5) + " mission quota\nFly more missions!!!";
    }
}
