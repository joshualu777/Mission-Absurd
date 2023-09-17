using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinDisplay : MonoBehaviour
{
    public TextMeshProUGUI coins;

    void Update()
    {
        coins.text = "Coins Remaining:\n" + GameManager.Instance.GetCoins();
    }
}
