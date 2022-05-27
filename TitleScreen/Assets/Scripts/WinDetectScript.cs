using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetectScript : MonoBehaviour
{

    public Pickup pickupscript;
    public GameObject basementSequence;
    public GameObject boxZoom;
    public Room2Movement move;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.layer == 8)
        {
            WinBoxes();
            
        }
    }
    
    public void WinBoxes(){
        pickupscript.ItemToInv(basementSequence);
        move.EnterBasement2();
        boxZoom.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        pickupscript = GameObject.Find("PickupScript").GetComponent<Pickup>();
        boxZoom = GameObject.Find("Boxes");
        move = GameObject.Find("Room2").GetComponent<Room2Movement>();
    }
}
