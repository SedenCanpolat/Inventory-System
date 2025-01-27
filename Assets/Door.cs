using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    [SerializeField] private Item _key;
    private bool isLocked = true;
    public override bool Interact(Item item)
    {
        if(item != null && item.ID == _key.ID){
            Debug.Log("Door Opened :)");
            isLocked = false;
            return true;
        }
        else{
            Debug.Log("Door Couldn't Open");
            return false;
        }
    }

    public override bool IsInteractable(){
        return base.IsInteractable() && isLocked;
    }
}
