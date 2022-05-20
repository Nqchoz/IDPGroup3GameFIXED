using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musicboxscript : MonoBehaviour
{
    [SerializeField] private UI_InputWindow inputWindow;

   public Pickup pickupscript;
   public ShelfClicked movementscript;
   bool alreadychanged;
   public Image Musicbox;
   public Sprite MBWithHandle;
   public Button OpenTextFieldBTN;


   void Awake(){
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();
        movementscript = GameObject.FindGameObjectWithTag("MovementScript").GetComponent<ShelfClicked>();
        OpenTextFieldBTN = GameObject.Find("MusicBoxInteractHB").GetComponent<Button>();
        OpenTextFieldBTN.enabled = false;
   }

    public void MusicBoxInteract(){
        if (pickupscript.handleacquired && movementscript.camra.transform.position == movementscript.MusicBoxZoom1 && alreadychanged == false){
            Musicbox.GetComponent<Image>().sprite = MBWithHandle;
            OpenTextFieldBTN.enabled = true;
            
        }
        else if (pickupscript.handleacquired && movementscript.camra.transform.position == movementscript.MusicBoxZoom1 && alreadychanged == true){
            Debug.Log("buttonworks");
            inputWindow.Show("Enter PASSCODE", "5 letters", "abcdefghijklmnopqrstuvwxyz", 5);
        }


    }

    public delegate char onValidateInput(string text, int charIndex, char addedChar);


}
