using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePieces : MonoBehaviour
{
    private GameObject obj1;

    private float time = 0.0f;
    private string timer = "";

    public InputField mainInputField;

    [SerializeField] InputField feedback1;

    void Update()
    {
        time = Mathf.Abs(1800 - obj1.GetComponent<Clock>().timetodisplay);
        timer = time.ToString();
    }

    public GameObject[] FramePieces; // prefabs for the ones that go in the frame lol
    public GameObject[] invPieces; // prefabs for inventroy
    private bool[] attachedP = new bool[8];
    public Pickup pickup;
    public GameObject[] spawnedPieces;
    public int pieceNumber;
    private bool doneDialogue;
    public Room3Movement R3movement;
    private int piecesPlaced;
    public Inventory inventory;
    public bool temp;
    public GameObject Pict;
    public Room3Movement r3m;
    private Button radio;
    public SlotsScript slots;

    void Awake(){
        for (int i = 0; i<8; i++){
            attachedP[i] = false;
        }
        R3movement = GameObject.Find("Room3").GetComponent<Room3Movement>();
        piecesPlaced = 0;
        pickup = GameObject.Find("PickupScript").GetComponent<Pickup>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        obj1 = GameObject.FindGameObjectWithTag("Timer");
        r3m =GameObject.Find("Room3").GetComponent<Room3Movement>();
        radio = GameObject.Find("Radiohitbox").GetComponent<Button>();
        slots = GameObject.Find("SlotsScript").GetComponent<SlotsScript>();
    }
    
    public void FoundPiece(int i, GameObject gameobj){
        temp = false;
        for (int ie = 0; ie < inventory.slots.Length; ie++){
            if (inventory.isFull[ie] == false && temp == false){   
                pickup.ItemToInv(invPieces[i]);
                gameobj.SetActive(false);
                temp = true;
                if (doneDialogue == false){
                    //do dialogue
                    doneDialogue = true;
                }
            }

        }
    }

    public void AttachPiece(int i){
        if (R3movement.currentRoom == 1){
            Debug.Log(gameObject);
            spawnedPieces[i] = Instantiate(FramePieces[i], GameObject.Find("PictureFrameParent").transform, false);
            Destroy(GameObject.Find("piece" + (i+1) +"(Clone)"));
            attachedP[i] = true;
            for (int x = 0; x<8; x++){
                if (attachedP[x] == true){
                    piecesPlaced++;
                }
            }
            if (piecesPlaced == 8){
                for (int x = 0; x<8; x++){
                    Destroy(spawnedPieces[x]);
                    
                }
                
                mainInputField.text = timer;
                slots.ClearInv();
                pickup.ItemToInv(Pict);
                radio.enabled = true;
            }
            else{
                piecesPlaced = 0;
            }
        }
    }
    


}
