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
        if (slotItem.itemName == "�ե��J�O")
        {
            this.slotItem.itemHold = 1;
        }
        if (slotItem.itemName == "�¥��J�O")
        {
            this.slotItem.itemHold = 2;
        }
        if (slotItem.itemName == "�զ��Ĥ�")
        {
            this.slotItem.itemHold = 1;
        }
        if (slotItem.itemName == "�����Ĥ�")
        {
            this.slotItem.itemHold = 3;
        }
        if (slotItem.itemName == "����Ĥ�")
        {
            this.slotItem.itemHold = 7;
        }
        if (slotItem.itemName == "�����Ĥ�")
        {
            this.slotItem.itemHold = 1;
        }
        if (slotItem.itemName == "����Ĥ�")
        {
            this.slotItem.itemHold = 4;
        }
        if (slotItem.itemName == "�Ŧ��Ĥ�")
        {
            this.slotItem.itemHold = 4;
        }
        if (slotItem.itemName == "�_��")
        {
            this.slotItem.itemHold = 1;
        }     
    }
}
