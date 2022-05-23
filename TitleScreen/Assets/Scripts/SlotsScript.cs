using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotsScript : MonoBehaviour
{
    private Inventory inventory;
    public int slotnumber;
    public Pickup pickupscript;


    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount <= 0) {
            inventory.isFull[slotnumber] = false;

        }   
    }
    public void DestroyHandle(){
        Destroy(pickupscript.HandleClone);
    }

    
}
