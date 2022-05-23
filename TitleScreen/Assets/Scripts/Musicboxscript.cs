using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musicboxscript : MonoBehaviour
{
    [SerializeField] private UI_InputWindow inputWindow;

   public Pickup pickupscript;
   public ShelfClicked movementscript;
   public Image Musicbox;
   public Sprite MBWithHandle;
   public Sprite[] OMB; // all of the possible open box sprites
   public bool[] taken; // is key/paper taken?
   private Button[] items;
   public Button OpenTextFieldBTN;
   public SlotsScript slotsscript;
   public GameObject HeldHandle;
   

   void Awake(){
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();
        movementscript = GameObject.FindGameObjectWithTag("MovementScript").GetComponent<ShelfClicked>();
        OpenTextFieldBTN = GameObject.Find("MusicBoxInteractHB").GetComponent<Button>();
        slotsscript = GameObject.FindGameObjectWithTag("SlotsScript").GetComponent<SlotsScript>();
        Musicbox = GameObject.FindWithTag("MusicBoxZoomed").GetComponent<Image>();
        OpenTextFieldBTN.enabled = false;
   }

    public void MusicBoxInteract(){
        //add handle to the music box
        if (pickupscript.handleacquired && movementscript.camra.transform.position == movementscript.MusicBoxZoom1){
            Musicbox.GetComponent<Image>().sprite = MBWithHandle;
            slotsscript.DestroyHandle();
            OpenTextFieldBTN.enabled = true;
        
        }
    }

    public void MusicBoxInteract2(){
        //open the input field/text window
        Debug.Log("InputWindowBrokey");
        inputWindow.testing();

    }

    public void SolvedMusicBox(){
        OpenTextFieldBTN.enabled = false;
        Musicbox.GetComponent<Image>().sprite = OMB[0];

    }

    

    public delegate char onValidateInput(string text, int charIndex, char addedChar);


}
