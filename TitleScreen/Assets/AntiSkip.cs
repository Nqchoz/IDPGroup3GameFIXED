using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntiSkip : MonoBehaviour
{
    public Dragger dragger;


    void Awake(){
        dragger = GameObject.Find("FlowPuzzleCanvas").GetComponent<Dragger>(); // get the drag script 
       
    }

    void OnMouseOver(){
        dragger.enabledVar = false; 
    }
   



}
