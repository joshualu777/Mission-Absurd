using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryListController : MonoBehaviour
{
    public GameObject ItemList;

    void Start()
    {
        UpdateList();
        UpdateActive();
        ChangeColor(0, new Color32(84, 255, 0, 255));

        for (int i = 0; i < InventoryManager.Instance.allItems.Length; i++)
        {
            GameObject icon = ItemList.transform.GetChild(i).gameObject;
            icon.GetComponent<SlotController>().index = i;
        }
    }

    public void UpdateList()
    {
        Item[] items = InventoryManager.Instance.GetInventoryList();
        for (int i = 0; i < InventoryManager.Instance.GetInventoryListLength(); i++)
        {
            GameObject icon = ItemList.transform.GetChild(i).transform.GetChild(0).gameObject;
            icon.GetComponent<Image>().sprite = items[i].icon;
            icon.GetComponent<Image>().color = new Color32(items[i].r, items[i].g, items[i].b, 255);
        }
    }

    public void UpdateActive()
    {
        Item[] items = InventoryManager.Instance.GetInventoryList();
        for (int i = 1; i < InventoryManager.Instance.GetInventoryListLength(); i++)
        {
            ChangeColor(i, new Color32(255, 255, 255, 255));
        }
        ChangeColor(InventoryManager.Instance.GetActiveItem(), new Color32(84, 255, 0, 255));
    }

    private void ChangeColor(int index, Color32 color)
    {
        GameObject slot = ItemList.transform.GetChild(index).gameObject;
        var colors = slot.GetComponent<Button>().colors;
        colors.normalColor = color;
        slot.GetComponent<Button>().colors = colors;
    }
}
