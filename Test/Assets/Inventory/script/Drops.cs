using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drops : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInventory;
    private int pack;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            if (InventoryManager.instance.slotGrid.transform.childCount == 6)
                return;
            AddNewItem();
            Destroy(gameObject);
        }
    }
    public void AddNewItem() 
    {
        if (!playerInventory.itemList.Contains(thisItem))
        {
            playerInventory.itemList.Add(thisItem);
        }
        else
        {
            thisItem.itemHold += 1;
        }
        InventoryManager.ReflashItem(); 
    }
}
