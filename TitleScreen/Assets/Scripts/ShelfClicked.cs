using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShelfClicked : MonoBehaviour
{

    public GameObject camra;
    public Colorlock clscript;
    Vector3 ShelfExitZoomVector = new Vector3(960f, 540f, -10f);
    Vector3 Shelf2ZoomVector = new Vector3(960f, 2700f, -10f);
    Vector3 Shelf3ZoomVector = new Vector3(960f, 1620f, -10f);
    Vector3 BedroomRoom2Vector = new Vector3(2880f, 540f, -10f);
    Vector3 DiaryZoomVector = new Vector3(2880f, 1620f, -10f);
    Vector3 ColorlockZoomVector = new Vector3(2880f, 2700f, -10f);
    Vector3 OpenDiary1 = new Vector3(2880f, 3780f, -10f);
    Vector3 OpenDiary2 = new Vector3(2880f, 4860f, -10f);
    Vector3 OpenDiary3 = new Vector3(2880f, 5940f, -10f);
    Vector3 MusicBoxZoom1 = new Vector3(960f, 3780f, -10f);
    Button colorlockzoombutton;
    Button opendiarybutton;
    public bool DiaryUnlocked;
    
    void Awake(){
        clscript = FindObjectOfType<Colorlock>();
        colorlockzoombutton = GameObject.FindGameObjectWithTag("Colorlockbutton").GetComponent<Button>();
        opendiarybutton = GameObject.FindGameObjectWithTag("OpenDiaryButton").GetComponent<Button>();
        opendiarybutton.enabled = false;
        Debug.Log(opendiarybutton.enabled);
    }
    public void Shelf_ExitZoom(){

        camra.transform.position = ShelfExitZoomVector;
    }

    public void Shelf_2Zoom()
    {
       
        camra.transform.position = Shelf2ZoomVector;
        
    }
     public void Shelf_3Zoom()
    {
     
        camra.transform.position = Shelf3ZoomVector;
    }
    public void Bedroom_2Enter()
    {
     
        camra.transform.position = BedroomRoom2Vector;
    }
    
    public void DiaryZoom()
    {
       
        camra.transform.position = DiaryZoomVector;
        
    }
    
    public void ColorlockZoom()
    {
       
        camra.transform.position = ColorlockZoomVector;
        
    }
    public void DiaryPage1()
    {
       
        camra.transform.position = OpenDiary1;
        
    }
    public void DiaryPage2()
    {
       
        camra.transform.position = OpenDiary2;
        
    }
    public void DiaryPage3()
    {
       
        camra.transform.position = OpenDiary3;
        
    }
    public void MusicBoxZoom()
    {
       
        camra.transform.position = MusicBoxZoom1;
        
    }


    void Update(){
        if (clscript.Locksolved == true && DiaryUnlocked == false){
            colorlockzoombutton.enabled = false;
            DiaryZoom();
            opendiarybutton.enabled = true;
            Debug.Log(opendiarybutton.enabled);
            DiaryUnlocked = true;

        }

    }
}
