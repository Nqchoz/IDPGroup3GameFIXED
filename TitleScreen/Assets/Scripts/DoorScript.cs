using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public Pickup pickupscript;
    public Room2Movement Room2M;
    public SlotsScript slots;

    void Awake(){
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();
        Room2M = GameObject.Find("Room2").GetComponent<Room2Movement>();
        slots = GameObject.FindGameObjectWithTag("SlotsScript").GetComponent<SlotsScript>();
    }
    public void DoorClicked(){
        if (pickupscript.Room2Access == true){
            Room2M.EnterBasement();
            slots.ClearInv();
        }
        else{
            Debug.Log("Its the basement door.\n It might have some old stuff I might remember, but I can't seem to get there yet");
        }


    }
}
