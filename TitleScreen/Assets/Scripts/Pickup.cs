using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public Inventory inventory;
    public GameObject itemButton;
    public GameObject HintIcon;
    public GameObject itemHandle;
    public bool handleacquired;
    public GameObject HandleClone;
    public bool Room2Access;
    public GameObject HintClone;
    public GameObject[] heldItems;

    public void Start(){

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void AddToInv(){
       
        for (int i = 0; i < inventory.slots.Length; i++){
            if (inventory.isFull[i] == false){
                inventory.isFull[i] = true;
                Instantiate(itemButton, inventory.slots[i].transform, false);
                Destroy(gameObject);
                break;
            }
        }

        


    }
     public void HandleToInv(){
       
        for (int i = 0; i < inventory.slots.Length; i++){
            if (inventory.isFull[i] == false){
                inventory.isFull[i] = true;
                HandleClone = Instantiate(itemHandle, inventory.slots[i].transform, false);
                handleacquired = true;
                Debug.Log("Handle Acquired");
                break;
            }
        }

    

    }




    public void HintToInv(){
    
        for (int i = 0; i < inventory.slots.Length; i++){
            if (inventory.isFull[i] == false){
                inventory.isFull[i] = true;
                HintClone = Instantiate(HintIcon, inventory.slots[i].transform, false);
                break;
            }
        }

    }

    public void ItemToInv(GameObject ItemPrefab) {
    
        for (int i = 0; i < inventory.slots.Length; i++){
            if (inventory.isFull[i] == false){
                inventory.isFull[i] = true;
                heldItems[i] = Instantiate(ItemPrefab, inventory.slots[i].transform, false);
                Room2Access = true;
                break;
            }
        }

    }


    
}
