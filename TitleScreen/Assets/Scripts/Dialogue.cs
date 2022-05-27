using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public int test;
    public int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject DialogueGroup;
    public TextMeshProUGUI speaker;
    public string speakername;
    public string[] sentences;
    
    void Awake(){
        textDisplay = GameObject.Find("DialogueText").GetComponent<TextMeshProUGUI>();
        DialogueGroup = GameObject.Find("Dialogue");
        speaker = GameObject.Find("Speaker").GetComponent<TextMeshProUGUI>();
        continueButton.SetActive(false);

    }
    public void DoDialogue(){
        index = 0;
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
        Debug.Log((index + 1).ToString() + " out of " + sentences.Length.ToString());
        continueButton.SetActive(false);
        if (index < sentences.Length - 1){
            index ++;
            textDisplay.text = "";
            StartCoroutine(Type());

        }
        else{
            textDisplay.text = "";
            continueButton.SetActive(false);
            DialogueGroup.SetActive(false);
        }

    }

}
