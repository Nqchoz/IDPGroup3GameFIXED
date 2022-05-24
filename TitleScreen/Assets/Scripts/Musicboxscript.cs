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
   private Button KeyButton;
   private Button PicButton;
   public Button OpenTextFieldBTN;
   public GameObject OTFGO;
   public GameObject OpenTextFieldBTNGO; //for moving it
   private SlotsScript slotsscript;
   public GameObject KeyItem;
   public GameObject PicItem;

   

   void Awake(){
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();
        movementscript = GameObject.FindGameObjectWithTag("MovementScript").GetComponent<ShelfClicked>();
        OTFGO = GameObject.FindWithTag("OTFGO");
        OpenTextFieldBTN = GameObject.Find("MusicBoxInteractHB").GetComponent<Button>();
        slotsscript = GameObject.FindGameObjectWithTag("SlotsScript").GetComponent<SlotsScript>();
        Musicbox = GameObject.FindWithTag("MusicBoxZoomed").GetComponent<Image>();
        OpenTextFieldBTN.enabled = false;
        KeyButton = GameObject.FindWithTag("KeyButton").GetComponent<Button>();
        PicButton = GameObject.FindWithTag("PicButton").GetComponent<Button>();
        KeyButton.enabled = false;
        PicButton.enabled = false;
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
        KeyButton.enabled = true;  //enable the buttons
        PicButton.enabled = true;
        Debug.Log (PicButton.enabled);
        OpenTextFieldBTN.enabled = false;
        OTFGO.transform.localPosition = new Vector3(-1920, 0, 0);

    }

    // if you take the key
    public void MusicBoxKey(){
        if (taken[1] == true){
            Musicbox.GetComponent<Image>().sprite = OMB[3];
        }
        else{
            Musicbox.GetComponent<Image>().sprite = OMB[1];
        }
        KeyButton.enabled = false;
        taken[0] = true;
        pickupscript.ItemToInv(KeyItem);
        Debug.Log("Key has been acquired");
    }
    // if you take the picture
    public void MusicBoxPic(){
        if (taken[0] == true){
            Musicbox.GetComponent<Image>().sprite = OMB[3];
        }
        else{
            Musicbox.GetComponent<Image>().sprite = OMB[2];
        }
        PicButton.enabled = false;
        taken[1] = true;
        pickupscript.ItemToInv(PicItem);
        Debug.Log("Picture has been acquired");
    }
    
    public void TestingButtonsBruh(){
        Debug.Log("buttonWorks");
    }
    public delegate char onValidateInput(string text, int charIndex, char addedChar);


}
