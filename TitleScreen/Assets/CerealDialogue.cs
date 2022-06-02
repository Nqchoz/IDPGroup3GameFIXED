using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CerealDialogue : MonoBehaviour
{
    public DialogueREWORK radioinfo;

    public TextMeshProUGUI textDisplay;
    public GameObject continueButton;
    public GameObject DialogueGroup;
    public TextMeshProUGUI speaker;
    // Start is called before the first frame update
    void Start()
    {
        continueButton.SetActive(false);
    }
    public void DoDialogue1(){
        radioinfo.index = 0;
        DialogueGroup.SetActive(true);
        Debug.Log("starting dialogue");
        StartCoroutine(Type1());
       
    }

    void Update(){
        if(textDisplay.text == radioinfo.sentences[radioinfo.index]){
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type1(){
        Debug.Log("Typing");
        speaker.text = radioinfo.speakername;
        foreach(char letter in radioinfo.sentences[radioinfo.index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(radioinfo.typingSpeed);
        }
    }

    public void NextSentence1(){
        continueButton.SetActive(false);
        if (radioinfo.index < radioinfo.sentences.Length - 1){
            radioinfo.index ++;
            textDisplay.text = "";
            StartCoroutine(Type1());

        }
        else{
            textDisplay.text = "";
            continueButton.SetActive(false);
            DialogueGroup.SetActive(false);
        }

    }
    
}
