using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timetodisplay;
    public bool timerpower;
    
    // Start is called before the first frame update
    void Start()
    {
        timetodisplay = 30*60;    
        timerpower = true;
    }

    void countdown()
    {
        timetodisplay -= Time.deltaTime;
        float minutes = Mathf.FloorToInt(timetodisplay / 60); 
        float seconds = Mathf.FloorToInt(timetodisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
    // Update is called once per frame
    void Update()
    {
        if (timerpower){

                if (timetodisplay >= 0){    
                countdown();

            }

            if(timetodisplay<0){

                Debug.Log("Time has run out!");
                timerpower = false;

            }

        }
        
    }
}
