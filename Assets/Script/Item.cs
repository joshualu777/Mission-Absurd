using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory Item")]
public class Item : ScriptableObject
{
    public Sprite icon = null;
    public byte r = 0;
    public byte g = 0;
    public byte b = 0;

    public int getCode()
    {
        return r * 1 + g * 7 + b * 49;
    }
}
