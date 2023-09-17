using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    public int index;

    public void ClickSlot()
    {
        Debug.Log(index + " " + InventoryManager.Instance.GetInventoryListLength());
        if (index < InventoryManager.Instance.GetInventoryListLength())
        {
            Item[] availableItems = InventoryManager.Instance.GetInventoryList();
            Item item = availableItems[index];

            Item[] allItems = InventoryManager.Instance.allItems;
            for (int i = 0; i < allItems.Length; i++)
            {
                Item cur = allItems[i];
                if (item.getCode() == cur.getCode())
                {
                    InventoryManager.Instance.activeColor = i;
                    break;
                }
            }
            InventoryManager.Instance.SetActive(index);
            FindObjectOfType<InventoryListController>().UpdateActive();
        }
    }

}
