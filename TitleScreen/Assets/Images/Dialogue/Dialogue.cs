using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject DialogueGroup;
    public TextMeshProUGUI speaker;
    public string speakername;
    
    void Awake(){
        continueButton = GameObject.Find("Continue");
        textDisplay = GameObject.Find("DialogueText").GetComponent<TextMeshProUGUI>();
        DialogueGroup = GameObject.Find("Dialogue");
        speaker = GameObject.Find("Speaker").GetComponent<TextMeshProUGUI>();

    }
    public void DoDialogue(){
        DialogueGroup.SetActive(true);
        StartCoroutine(Type());
    }

    void Update(){
        if(textDisplay.text == sentences[index]){
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type(){
        speaker.text = speakername;
        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence(){
        continueButton.SetActive(false);
        if (index < sentences.Length - 1){
            index ++;
            textDisplay.text = "";
            StartCoroutine(Type());

        }
        else{
            textDisplay.text = "";
            continueButton.SetActive(false);
        }

    }

}
