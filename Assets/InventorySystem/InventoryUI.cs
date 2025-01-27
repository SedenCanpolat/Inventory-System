using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public void OnItemAdded(Item item){
        Debug.Log(item.Name + " Added To Inventory");
    }

    public void OnItemRemoved(Item item){
        
    }

    public Item SelectedItem;

    public void SelectItem(Item item){
        SelectedItem = item;
    }
}
