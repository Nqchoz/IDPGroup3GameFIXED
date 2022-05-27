using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueSandtimerFlip : MonoBehaviour
{
    public Image BTimer;
    public List<Sprite> Sprites;
    public int stage;
    public Pickup pickupscript;
    
   

    void Awake(){
        stage = 0;
        BTimer.GetComponent<Image>().sprite = Sprites[stage];
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();
        
    }
    public void SpinTimer(){
        if (stage < 5){
            stage ++;
            BTimer.GetComponent<Image>().sprite = Sprites[stage];
        }
        if (stage == 5 && pickupscript.handleacquired == false){
            pickupscript.HandleToInv();

        }
        

        
    }



}
