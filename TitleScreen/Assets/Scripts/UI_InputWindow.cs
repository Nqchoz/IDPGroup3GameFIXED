using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_InputWindow : MonoBehaviour
{ 
    public Musicboxscript MBScript;
    public Button okBtn;
    public Button cancelBtn;
    public TextMeshProUGUI titleText;
    public TMP_InputField inputField;
    public String CorrectPass;

    private void Awake(){
        okBtn = GameObject.FindGameObjectWithTag("OkButton").GetComponent<Button>();
        cancelBtn = GameObject.FindGameObjectWithTag("CancelButton").GetComponent<Button>();
        titleText = GameObject.FindGameObjectWithTag("Title").GetComponent<TextMeshProUGUI>();
        inputField = GameObject.FindGameObjectWithTag("InputField").GetComponent<TMP_InputField>();
        Hide();

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
            MBScript.SolvedMusicBox();

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
