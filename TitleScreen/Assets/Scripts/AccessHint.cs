using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessHint : MonoBehaviour
{
    public Hints hintsscript;

    void Awake(){
        hintsscript = GameObject.Find("HintPopup").GetComponent<Hints>();

    }

    public void InvHintGet(){
        hintsscript.invhint();
    }

}
