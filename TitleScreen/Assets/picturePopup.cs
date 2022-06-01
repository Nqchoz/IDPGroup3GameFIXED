using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picturePopup : MonoBehaviour
{
    public ExitPopup exit;

    void Awake(){
        exit = GameObject.Find("Popup").GetComponent<ExitPopup>();
    }
    public void popupc(){
        exit.openPicture();
    }
}
