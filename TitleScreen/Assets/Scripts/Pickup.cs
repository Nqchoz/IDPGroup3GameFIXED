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
                Instantiate(itemHandle, inventory.slots[i].transform, false);
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
                Instantiate(HintIcon, inventory.slots[i].transform, false);
                break;
            }
        }

    }


    
}
