using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

   void Update(){
        var seenObject = _raycast();

        if(Input.GetMouseButtonDown(0)){
               if(seenObject && seenObject.IsInteractable()){
                    seenObject.Interact(null);
               }  
        }

        if(Input.GetMouseButtonUp(0)){
               if(seenObject && seenObject.IsInteractable() && Inventory.instance.ItemOnHand){
                    if(seenObject.Interact(Inventory.instance.ItemOnHand)){
                         var item = Inventory.instance.ItemOnHand;
                         Inventory.instance.EmptyHand();
                         Inventory.instance.RemoveItem(item);
                    }
               }
               Inventory.instance.EmptyHand();    
        }
        
        print(seenObject?.name);
   }

   private Interactable _raycast(){
        Interactable seen = null;

        RaycastHit raycastHit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if( Physics.Raycast(ray,out raycastHit)){
             raycastHit.collider.TryGetComponent(out seen);
        }
        return seen;
   }
}
