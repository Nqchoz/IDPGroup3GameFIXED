using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandfatherClock : MonoBehaviour
{
    public GameObject minutehand;
    public GameObject hourhand;

    void Awake(){
        minutehand = GameObject.Find("MinuteHand");
        hourhand = GameObject.Find("HourHand");
    }

    void Update(){
        minutehand.transform.Rotate(0f, 0f, 6f);
        hourhand.transform.Rotate(0f, 0f, 6f); 
    }
}
