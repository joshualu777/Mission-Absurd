using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Item[] allItems;
    public int activeColor;

    private bool[] contains;

    private Item[] inventoryItems;
    private int nextEmpty;
    private int active;

    private static InventoryManager instance;

    public static InventoryManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<InventoryManager>();
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
        inventoryItems = new Item[allItems.Length];
        contains = new bool[allItems.Length];

        inventoryItems[0] = allItems[0];
        contains[0] = true;
        inventoryItems[1] = allItems[1];
        contains[1] = true;

        nextEmpty = 2;
        active = 1;

        activeColor = 1;
    }

    public bool SetActive(int index)
    {
        if (index != 0)
        {
            active = index;
            return true;
        }
        return false;
    }

    public int GetActiveItem()
    {
        return active;
    }

    public bool AddItem(int index)
    {
        if (!contains[index])
        {
            contains[index] = true;
            inventoryItems[nextEmpty++] = allItems[index];
            return true;
        }
        return false;
    }

    public Item[] GetInventoryList()
    {
        return inventoryItems;
    }

    public int GetInventoryListLength()
    {
        return nextEmpty;
    }
}
