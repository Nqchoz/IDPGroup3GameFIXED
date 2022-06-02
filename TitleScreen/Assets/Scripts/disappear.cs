using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disappear : MonoBehaviour
{
    public Inventory inventory;
    
    void Awake(){
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void disappears(){
        for (int ie = 0; ie < inventory.slots.Length; ie++){
            if (inventory.isFull[ie] == false){
                gameObject.GetComponent<Button>().enabled = false;
            }
        }    
    }
}
