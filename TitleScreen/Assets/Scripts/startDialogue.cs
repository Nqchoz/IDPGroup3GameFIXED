using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startDialogue : MonoBehaviour
{
    
    public Dialogue dscript;

    void Start()
    {
        dscript = GameObject.Find("Dialogue").GetComponent<Dialogue>();
        dscript.typingSpeed = 0.01f; // set to 0.04
        dscript.speakername = "Kevin";
        dscript.DoDialogue();
        Debug.Log(gameObject.name);
    }

    public void MakeDialogue(Dialogue dscript1, string[] sent){
        if (dscript.DialogueGroup.activeSelf == false){    
            dscript1.typingSpeed = 0.01f; // set to 0.04f
            dscript1.speakername = "Kevin";
            dscript.sentences =   sent;
            dscript.index = 0;
            dscript1.DoDialogue();
        }            
    }
}
