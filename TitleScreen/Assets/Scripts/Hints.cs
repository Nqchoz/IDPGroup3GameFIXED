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

    public int indexhint;
    public GameObject obj1;
    public Canvas HintBox;
    public Image HintBoxImage;
    public TextMeshProUGUI HintTextBox;
    public Button hintbutton;


    void Awake(){
        indexhint = 1;
        obj1 = GameObject.FindGameObjectWithTag ("Timer");
    }

    public void gethint(){
        obj1.GetComponent<Clock> ().timetodisplay -= hintdeduct[indexhint];
        StartCoroutine(showbubble());

    }

    IEnumerator showbubble(){
        HintTextBoxBox.text = hintinfo[indexhint];
        HintBox.color = new Color(1, 1, 1, 0);
        HintBox.enabled = true;
        for (int i = 0; i < 5; i+= Time.deltaTime){
            HintBoxBox.color = new Color(1, 1, 1, i);
        }
        hintbutton.interactable = false;
        yield return new WaitForSeconds(6);
        for (int i = 5; i > 0; i-=Time.deltaTime)
        {
            HintBoxBox.color = new Color(1, 1, 1, i);
        }
        HintBox.enabled = false;
        hintbutton.interactable = true;
    }
}
