using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_InputWindow : MonoBehaviour
{ 

    public Button okBtn;
    public Button cancelBtn;
    public TextMeshProUGUI titleText;
    public TMP_InputField inputField;

    private void Awake(){
        okBtn = GameObject.FindGameObjectWithTag("OkButton").GetComponent<Button>();
        cancelBtn = GameObject.FindGameObjectWithTag("CancelButton").GetComponent<Button>();
        titleText = GameObject.FindGameObjectWithTag("Title").GetComponent<TextMeshProUGUI>();
        inputField = GameObject.FindGameObjectWithTag("InputField").GetComponent<TMP_InputField>();
        Hide();

    }

    public void Show(string titleString, string inputString, string validCharacters, int characterLimit){
        gameObject.SetActive(true);
        titleText.text = titleString;
        inputField.characterLimit = characterLimit;
        inputField.onValidateInput = (string text, int charIndex, char addedChar)=>{
            return ValidateChar(validCharacters, addedChar);

        };

        inputField.text = inputString;

    }

    public void Hide(){
        gameObject.SetActive(false);
    }

    public void onOkClicked(){
        if (inputField.text == "macky"){
            Hide();

        }
        else{
            inputField.text = "INCORRECT. TRY AGAIN SCHMUCK";
        }
        

    }
    public void onCancelClicked(){
        Hide();

    }
    public void testing(){

        Show("Enter Password", "5 Letters", "abcdefghijklmnopqrstuvwxyz", 5);

    }
    private char ValidateChar(string validCharacters, char addedChar){
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