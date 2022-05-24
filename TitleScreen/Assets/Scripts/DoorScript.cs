using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public Pickup pickupscript;
    void Awake(){
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();

    }
    public void DoorClicked(){
        if (pickupscript.Room2Access == true){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else{
            Debug.Log("Its the basement door.\n It might have some old stuff I might remember, but I can't seem to get there yet");
        }


    }
}
