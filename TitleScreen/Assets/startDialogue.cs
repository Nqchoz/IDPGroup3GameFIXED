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
        dscript.typingSpeed = 0.02f;
        dscript.sentences = {"Mmmm… I remember having a music box somewhere around here."};
        dscript.speakername = "Kevin"
        dscript.DoDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
