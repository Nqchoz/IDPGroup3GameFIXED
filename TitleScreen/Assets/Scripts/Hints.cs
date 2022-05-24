using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;

public class Hints : MonoBehaviour
{

    public string[] hintinfo = { "If you don't get out of here, you may never see this color outside again.", "These books have the same color as the diary's lock…", 
    "These pages don't seem to be in order…", "It's pretty dark in here, maybe I can figure out how to turn the lights on...",
    "Maybe you can slide these boxes enough so you can pass through.", "Think about the first letter of each drawing..", 
    "Put the pieces of the photo together. There's more than just a picture.", "Huh, since when did the clock start to chime? It hasn't even struck 12!", 
    "Your mom really cares about you, even if it doesn't seem like it."};
    public int[] hintdeduct = {30, 60, 60, 60, 60, 60, 30, 60, 60};
    public bool[] AlreadyHinted = {false, false, false, false, false, false, false, false, false};
    public static int indexhint;
    public GameObject obj1;
    public Canvas HintBox;
    public CanvasGroup HintBoxGroup;
    public TextMeshProUGUI HintTextBox;
    public Button hintbutton;
    public Pickup pickupscript;
    public SlotsScript slotsscript;
    



    void Start(){
        indexhint = 1;
        obj1 = GameObject.FindGameObjectWithTag ("Timer");
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();
        HintBoxGroup = GameObject.Find("HintBubble").GetComponent<CanvasGroup>();
        HintTextBox = GameObject.Find("HintBubbleText").GetComponent<TMPro.TextMeshProUGUI>();
        HintBox = GameObject.Find("HintBubble").GetComponent<Canvas>();
        hintbutton = GameObject.Find("HintButton").GetComponent<Button>();
        slotsscript = GameObject.Find("SlotsScript").GetComponent<SlotsScript>();
        

    }

    public void gethint(){
        if (AlreadyHinted[indexhint] != true){
            obj1.GetComponent<Clock> ().timetodisplay -= hintdeduct[indexhint];
            AlreadyHinted[indexhint] = true;
            StartCoroutine(showbubble());
            StartCoroutine(AntiDuplication());
       }
    }

    
        

    public void invhint(){
        StartCoroutine(showbubble());
        StartCoroutine(AntiSpam());

    }
    public void UpdateHint(){
        slotsscript.DestroyHint();
        indexhint++;
        Debug.Log(indexhint);

    }

    IEnumerator showbubble(){
        HintTextBox.text = hintinfo[indexhint];
        HintBoxGroup.alpha = 0;
        HintBox.enabled = true;
        while(HintBoxGroup.alpha < 1){
            HintBoxGroup.alpha += (float)0.15;
            yield return new WaitForSeconds((float)0.03);
        }

        hintbutton.interactable = false;
        yield return new WaitForSeconds(4);
        while(HintBoxGroup.alpha > 0){
            HintBoxGroup.alpha -= (float)0.15;
            yield return new WaitForSeconds((float)0.03);
        }
        pickupscript.HintClone.GetComponent<Button>().enabled = true;
        HintBox.enabled = false;
        hintbutton.interactable = true;
        
        


    }
    IEnumerator AntiDuplication(){
        yield return new WaitForSeconds((float)4.3);
        pickupscript.HintToInv();
    }
     IEnumerator AntiSpam(){
        pickupscript.HintClone.GetComponent<Button>().enabled = false;
        yield return new WaitForSeconds((float)4.3);
        pickupscript.HintClone.GetComponent<Button>().enabled = true;
    
    }


}
