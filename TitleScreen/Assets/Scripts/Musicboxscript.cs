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
   public SlotsScript slotsscript;
   public GameObject HeldHandle;

   void Awake(){
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();
        movementscript = GameObject.FindGameObjectWithTag("MovementScript").GetComponent<ShelfClicked>();
        OpenTextFieldBTN = GameObject.Find("MusicBoxInteractHB").GetComponent<Button>();
        slotsscript = GameObject.FindGameObjectWithTag("SlotsScript").GetComponent<SlotsScript>();
       
   }

    public void MusicBoxInteract(){
        if (pickupscript.handleacquired && movementscript.camra.transform.position == movementscript.MusicBoxZoom1 && alreadychanged == false){
            Musicbox.GetComponent<Image>().sprite = MBWithHandle;
            alreadychanged = true;
        }
    }
    public void MusicBoxInteract2(){
        if (alreadychanged == true){
            Debug.Log("buttonworks");
            inputWindow.testing();
            
        }

    }

    

    public delegate char onValidateInput(string text, int charIndex, char addedChar);


}
