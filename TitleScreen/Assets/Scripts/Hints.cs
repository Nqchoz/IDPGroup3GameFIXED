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
    public float timestart;
    public GameObject AnimationBubble;
    public string HintText;
    public TextMeshProUGUI HintTextBox;


    void Awake(){
        indexhint = 1;
        obj1 = GameObject.FindGameObjectWithTag ("Timer");
        HintText = hintinfo[indexhint];
    }

    public void gethint(){

        obj1.GetComponent<Clock> ().timetodisplay -= hintdeduct[indexhint];
        HintTextBox = GameObject.FindGameObjectWithTag("HintText");
        showbubble();

    }

    public void showbubble(){
        GameObject prefab = Instantiate(AnimationBubble, transform.position, Quaternion.identity);
        HintTextBox.text = HintText;
        
    }
}
