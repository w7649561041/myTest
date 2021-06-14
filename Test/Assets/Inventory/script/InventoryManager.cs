using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public Inventory myBag;
    public GameObject slotGrid;
    public Slot slotPrefab;
    public Slot thisSlot;
    public Text itemInfo;
    public Text itemName;
    public Image itemImage;
    void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }
    private void OnEnable()
    {
        ReflashItem();
        instance.itemInfo.text = "";
        instance.itemName.text = "";
    }
    public static void UpdateItemInfo(string itemDescription,string itemName,Sprite itemImage)  
    {
        instance.itemInfo.text = itemDescription;
        instance.itemName.text = itemName;
        instance.itemImage.sprite = itemImage;
    }
    public static void CreateNewItem(Item item)
    {
        Slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
        newItem.slotCount.text = item.itemHold.ToString();
    }
    public static void ReflashItem() 
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++) 
        {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < instance.myBag.itemList.Count; i++) 
        {
            CreateNewItem(instance.myBag.itemList[i]);
        }
    }
    public static void DeleteItem(Slot slot) 
    {
        for (int i = 0; i < instance.myBag.itemList.Count; i++) 
        {
            if (slot.slotItem.itemHold == 0) 
            {
                instance.myBag.itemList.RemoveAt(i);
                instance.itemInfo.text = "";
                instance.itemImage.sprite = null;
                instance.itemName.text = "";
                break;
            }
        }
    }
    public static void useItem(Slot slot) 
    {
        slot = instance.thisSlot;
        if (slot.slotItem.itemHold == 0)
            return;
        slot.slotItem.itemHold-=1;
        InventoryManager.DeleteItem(slot);
        InventoryManager.ReflashItem();
    }
    public static void mySlot(Slot slot)
    {
         instance.thisSlot=slot;
    }
}