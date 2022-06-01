using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pictureClose : MonoBehaviour
{
    public Sprite[] pictureStates;
    public ExitPopup exit;
    public Image image;
    public int stateIndex;
    void Awake(){
        exit = GameObject.Find("Popup").GetComponent<ExitPopup>();
    }
    public void popupexit(){
        exit.closePicture();
    }
    public void SpinPicture(){
        if (stateIndex == 0){
            stateIndex++;
            image.sprite = pictureStates[stateIndex];

        }
        else{
            stateIndex--;
            image.sprite = pictureStates[stateIndex];
        }
    }
}
