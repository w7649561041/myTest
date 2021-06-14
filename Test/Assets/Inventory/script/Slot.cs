using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item slotItem;
    public Image slotImage;
    public Text slotCount;


    public void ItemOnClicked()
    {
        InventoryManager.UpdateItemInfo(slotItem.itemInfo, slotItem.itemName,slotItem.itemImage);
        InventoryManager.mySlot(this);
    }
    public void initial()
    {
        if (slotItem.itemName == "白巧克力")
        {
            this.slotItem.itemHold = 1;
        }
        if (slotItem.itemName == "黑巧克力")
        {
            this.slotItem.itemHold = 2;
        }
        if (slotItem.itemName == "白色藥水")
        {
            this.slotItem.itemHold = 1;
        }
        if (slotItem.itemName == "紅色藥水")
        {
            this.slotItem.itemHold = 3;
        }
        if (slotItem.itemName == "橙色藥水")
        {
            this.slotItem.itemHold = 7;
        }
        if (slotItem.itemName == "黃色藥水")
        {
            this.slotItem.itemHold = 1;
        }
        if (slotItem.itemName == "綠色藥水")
        {
            this.slotItem.itemHold = 4;
        }
        if (slotItem.itemName == "藍色藥水")
        {
            this.slotItem.itemHold = 4;
        }
        if (slotItem.itemName == "鑰匙")
        {
            this.slotItem.itemHold = 1;
        }     
    }
}
