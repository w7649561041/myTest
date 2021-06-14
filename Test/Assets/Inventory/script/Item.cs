using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="NewItem",menuName ="Inventory/NewItem")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public int itemHold;
    [TextArea]
    public string itemInfo;
    public bool key;
}
