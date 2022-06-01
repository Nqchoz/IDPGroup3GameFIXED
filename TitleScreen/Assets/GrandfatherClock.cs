using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GrandfatherClock : MonoBehaviour
{
    public GameObject minutehand;
    public GameObject hourhand;
    public TextMeshProUGUI Hourhandtime;
    public TextMeshProUGUI minutehandtime;
    public Room3Movement R3m;
    public AudioSource bell;

    void Awake(){
        minutehand = GameObject.Find("MinuteHand");
        hourhand = GameObject.Find("HourHand");
        Hourhandtime = GameObject.Find("Hourhandtime").GetComponent<TextMeshProUGUI>();
        minutehandtime = GameObject.Find("minutehandtime").GetComponent<TextMeshProUGUI>();
        R3m = GameObject.Find("Room3").GetComponent<Room3Movement>();
        bell = GameObject.Find("ClockStrike").GetComponent<AudioSource>();
    }

    void Update(){
        if (R3m.Room1M.camra.transform.position == new Vector3(2880f+1920f, -1620f, -10f)){
            minutehand.transform.Rotate(0f, 0f, -3f);
            hourhand.transform.Rotate(0f, 0f, -1/4f);
            minutehandtime.text = ("rotation:" + hourhand.transform.rotation.eulerAngles.z);
            if (Mathf.RoundToInt(hourhand.transform.rotation.eulerAngles.z) == 300f){
                DoChime(1);
            }
            if (Mathf.RoundToInt(hourhand.transform.rotation.eulerAngles.z) == 240f){
                DoChime(2);
                
            }if (Mathf.RoundToInt(hourhand.transform.rotation.eulerAngles.z) == 210f){
                DoChime(3);
                
            }if (Mathf.RoundToInt(hourhand.transform.rotation.eulerAngles.z) == 120f){
                DoChime(4);
                
            }
        }    
    }
    public void DoChime(int i){
        Debug.Log("Doing Chime");
        Chime(i);
    }
    public IEnumerator Chime(int ie){
        Debug.Log("Why does that work");
        for (int x = 0; x < ie; x++){
            bell.Play();
            Debug.Log("not playing");
            yield return new WaitForSeconds(2);

        }
        
    }
}
