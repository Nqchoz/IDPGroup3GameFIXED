using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_InputWindow : MonoBehaviour
{
    //for timer stuff
    private GameObject obj1;

    private float time = 0.0f;
    private string timer = "";

    public InputField mainInputField;
    public InputField mainInputField2;
    public InputField mainInputField3;
    public Room3Movement R3movement;
    public SlotsScript slotsscript;

    [SerializeField] InputField feedback1;

    void Update()
    {
        time = Mathf.Abs(1800 - obj1.GetComponent<Clock>().timetodisplay);
        timer = time.ToString();
    }

    //actual code

    public Musicboxscript MBScript;
    public Button okBtn;
    public Button cancelBtn;
    public TextMeshProUGUI titleText;
    public TMP_InputField inputField;
    public String CorrectPass;
    public GameObject RadioGetDialogue;
    public Image safe;
    public Sprite openSafe;
    public GameObject safebutton1;
    public GameObject safebutton2;

    private void Awake(){
        okBtn = GameObject.FindGameObjectWithTag("OkButton").GetComponent<Button>();
        cancelBtn = GameObject.FindGameObjectWithTag("CancelButton").GetComponent<Button>();
        titleText = GameObject.FindGameObjectWithTag("Title").GetComponent<TextMeshProUGUI>();
        inputField = GameObject.FindGameObjectWithTag("InputField").GetComponent<TMP_InputField>();
        Hide();
        obj1 = GameObject.FindGameObjectWithTag("Timer");
        R3movement = GameObject.Find("Room3").GetComponent<Room3Movement>();
        slotsscript = GameObject.Find("SlotsScript").GetComponent<SlotsScript>();

    }
    //show the window with the set parameters
    public void Show(string titleString, string inputString, string validCharacters, int characterLimit){
        gameObject.SetActive(true);
        titleText.text = titleString;
        inputField.characterLimit = characterLimit;
        inputField.onValidateInput = (string text, int charIndex, char addedChar)=>{
            //test for valid characters
            return ValidateChar(validCharacters, addedChar);

        };
        
        inputField.text = inputString;

    }

    public void Hide(){
        gameObject.SetActive(false);
    }

    public void onOkClicked(){
        if (inputField.text == CorrectPass.ToString()){
            //if answer is correct
            Hide();
            if (CorrectPass == "macky"){
                MBScript.SolvedMusicBox();
            }
            if(CorrectPass == "dcahpb")
            {
                mainInputField.text = timer;
                Debug.Log(timer);
                R3movement.EnterRoom3();
                slotsscript.ClearInv();
                
            }
            if (CorrectPass == "2458"){
                GameObject.Find("Radiohitbox").SetActive(false);
                RadioGetDialogue.SetActive(true);
                mainInputField3.text = timer;
            }
            if (CorrectPass == "WAKE UP"){
                Debug.Log("You win!");
                safe.sprite = openSafe;
                safebutton1.SetActive(false);
                safebutton2.SetActive(true);
                mainInputField2.text = timer;
            }

        }
        else if (CorrectPass.ToString() == "2458"){
            Hide();
        }
        else{
            inputField.text = "INCORRECT.";
        }
        

    }
    public void onCancelClicked(){
        Hide();

    }
    public void testing(){
        //show the window with the parameters set to the following values
        Show("Enter Password", "5 Letters", "abcdefghijklmnopqrstuvwxyz", 5);
        CorrectPass = "macky";

    }
    public void ParentsRoom(){
        //show the window with the parameters set to the following values
        Show("Enter Password", "6 Letters", "abcdefghijklmnopqrstuvwxyz", 6);
        CorrectPass = "dcahpb";

    }
    public void RadioHZ(){
        //show the window with the parameters set to the following values
        Show("Enter Radio Frequency", "MAX 4 numbers", "1234567890", 4);
        CorrectPass = "2458";

    }
    public void Safe(){
        //show the window with the parameters set to the following values
        Show("Enter Passcode", "CAPITAL LETTERS", "ABCDEFGHIJKLMNOPQRSTUVWXYZ ", 7);
        CorrectPass = "WAKE UP";

    }
    private char ValidateChar(string validCharacters, char addedChar){
        //if the character inputted is in the string of valid characters
        if (validCharacters.IndexOf(addedChar)!= -1){
            //valid
            return addedChar;
        }
        else{
            //invalid
            return '\0';
        }
    }
   
   


    public delegate char onValidateInput(string text, int charIndex, char addedChar);

}
