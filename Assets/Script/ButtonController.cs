using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public Button quitButton;
    public Button spinButton;
    public TextMeshProUGUI Cathcart;

    public void StartGame()
    {
        GameManager.Instance.Reset();
        SceneManager.LoadScene("Game");
    }

    public void VisitLottery()
    {
        SceneManager.LoadScene("Lottery");
    }

    public void Spin()
    {
        if (GameManager.Instance.GetCoins() < 100)
        {
            return;
        }
        GameManager.Instance.UseCoins(100);
        FindObjectOfType<SimpleSpinner>().Rotation = true;
        FindObjectOfType<SimpleSpinner>().ResetSpinner();
        StartCoroutine(SpinDuration());
    }

    IEnumerator SpinDuration()
    {
        spinButton.interactable = false;
        yield return new WaitForSeconds(11);
        bool newItem = InventoryManager.Instance.AddItem(Random.Range(2, 12));
        if (newItem)
        {
            FindObjectOfType<InventoryListController>().UpdateList();
            //show new panel
        }
        else
        {
            //show old panel
        }
        spinButton.interactable = true;
    }

    public void QuitGame()
    {
        StartCoroutine(HighlightMessage());
    }

    IEnumerator HighlightMessage()
    {
        quitButton.interactable = false;
        TextMeshProUGUI textComponent = Cathcart.transform.GetComponent<TextMeshProUGUI>();
        byte r = (byte)(textComponent.color.r * 255);
        byte g = (byte)(textComponent.color.g * 255);
        byte b = (byte)(textComponent.color.b * 255);
        byte a = (byte)(textComponent.color.a * 255);
        textComponent.color = new Color32(255, 0, 0, 255);
        yield return new WaitForSeconds(3f);
        textComponent.color = new Color32(r, g, b, a);
        quitButton.interactable = true;
    }
}
