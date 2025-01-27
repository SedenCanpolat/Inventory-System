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
                seenObject.Interact(Inventory.instance.ItemOnHand);
            }
            
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
