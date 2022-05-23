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
        Musicbox = GameObject.FindWithTag("MusicBoxZoomed").GetComponent<Image>();
   }

    public void MusicBoxInteract(){
        if (pickupscript.handleacquired && movementscript.camra.transform.position == movementscript.MusicBoxZoom1 && alreadychanged == false){
            Musicbox.GetComponent<Image>().sprite = MBWithHandle;
            slotsscript.DestroyHandle();
            alreadychanged = true;
            Debug.Log(alreadychanged);
        }
    }
    public void MusicBoxInteract2(){
        if (alreadychanged == true){
            Debug.Log("InputWindowBrokey");
            inputWindow.testing();
            
            
        }
        else{
            Debug.Log("buttonworks");
        }

    }

    

    public delegate char onValidateInput(string text, int charIndex, char addedChar);


}
