using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup2 : MonoBehaviour
{
    public ExitPopup exit;

    void Awake(){
        exit = GameObject.Find("Popup").GetComponent<ExitPopup>();
    }
    public void popupB(){
        exit.openSequence();
    }
    public void popupCereal(){
        exit.openCereal();
    }
    public void closeCereal(){
        exit.closeCereal();
    }
}
