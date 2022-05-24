using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colorlock : MonoBehaviour
{
    private int[] combinations = {0, 1, 2, 3, 4, 5, 6, 7, 8 ,9};
    private int slot1;
    private int slot2;
    private int slot3;
    private int slot4;
    public TextMeshProUGUI slot1textbox;
    public TextMeshProUGUI slot2textbox;
    public TextMeshProUGUI slot3textbox;
    public TextMeshProUGUI slot4textbox;
    public bool Locksolved;
    public Hints Hintsscript;

    void Awake(){
        slot1 = 0;
        slot2 = 0;
        slot3 = 0;
        slot4 = 0;
        Locksolved = false;
        Hintsscript = GameObject.Find("HintPopup").GetComponent<Hints>();
    }
    
    public void slot1clicked(){
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        if (slot1 <8){
            slot1 = combinations[slot1+1];
            n1 = combinations[slot1-1];
            n2 = combinations[slot1];
            n3 = combinations[slot1+1];
        }
        else if (slot1 == 8){
            slot1 = combinations[slot1+1];
            n1 = combinations[slot1-1];
            n2 = combinations[slot1];
            n3 = combinations[0];


        }
        else {
            slot1 = combinations[0];
            n1 = combinations[9];
            n2 = combinations[slot1];
            n3 = combinations[slot1+1];
        }
        slot1textbox.text = (n1 + "\n" + n2 + "\n" + n3 + "\n");

    }

    public void slot2clicked(){
        int n12 = 0;
        int n22 = 0;
        int n32 = 0;
        if (slot2 <8){
            slot2 = combinations[slot2+1];
            n12 = combinations[slot2-1];
            n22 = combinations[slot2];
            n32 = combinations[slot2+1];
        }
        else if (slot2 == 8){
            slot2 = combinations[slot2+1];
            n12 = combinations[slot2-1];
            n22 = combinations[slot2];
            n32 = combinations[0];


        }
        else {
            slot2 = combinations[0];
            n12 = combinations[9];
            n22 = combinations[slot2];
            n32 = combinations[slot2+1];
        }
        slot2textbox.text = (n12 + "\n" + n22 + "\n" + n32 + "\n");


    }
    
    public void slot3clicked(){
        int n13 = 0;
        int n23 = 0;
        int n33 = 0;
        if (slot3 <8){
            slot3 = combinations[slot3+1];
            n13 = combinations[slot3-1];
            n23 = combinations[slot3];
            n33 = combinations[slot3+1];
        }
        else if (slot3 == 8){
            slot3 = combinations[slot3+1];
            n13 = combinations[slot3-1];
            n23 = combinations[slot3];
            n33 = combinations[0];


        }
        else {
            slot3 = combinations[0];
            n13 = combinations[9];
            n23 = combinations[slot3];
            n33 = combinations[slot3+1];
        }
        slot3textbox.text = (n13 + "\n" + n23 + "\n" + n33 + "\n");
    }

    public void slot4clicked(){
        int n14 = 0;
        int n24 = 0;
        int n34 = 0;
        if (slot4 <8){
            slot4 = combinations[slot4+1];
            n14 = combinations[slot4-1];
            n24 = combinations[slot4];
            n34 = combinations[slot4+1];
        }
        else if (slot4 == 8){
            slot4 = combinations[slot4+1];
            n14 = combinations[slot4-1];
            n24 = combinations[slot4];
            n34 = combinations[0];


        }
        else {
            slot4 = combinations[0];
            n14 = combinations[9];
            n24 = combinations[slot4];
            n34 = combinations[slot4+1];
        }
        slot4textbox.text = (n14 + "\n" + n24 + "\n" + n34 + "\n");
    }

    void Update(){
        if (slot1 == 9 && slot2 == 6 && slot3 == 3 && slot4 == 7 && Locksolved == false){
            Hintsscript.UpdateHint();
            Locksolved = true;
        }
    }







}
