using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openpopup : MonoBehaviour
{
    public ExitPopup exit;

    void Awake(){
        exit = GameObject.Find("Popup").GetComponent<ExitPopup>();
    }
    public void popup(){
        exit.openPopup();
    }

}
