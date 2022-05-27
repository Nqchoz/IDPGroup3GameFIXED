using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2Movement : MonoBehaviour
{
   public ShelfClicked Room1M; 
   Vector3 Basement1 = new Vector3(960f, -540f, -10f);
   Vector3 ElectricalBox = new Vector3(960f, -1620f, -10f);
   Vector3 Basement2 = new Vector3(960f, -2700f, -10f);
   Vector3 BoxPuzzle = new Vector3(-960, -2700, -10f);
   Vector3 Hallway = new Vector3(960, -3780, -10f);
   int CameraSizeNormal = 540;
   int CameraSizeBoxP = 30;


    void Awake(){
        Room1M = GameObject.Find("ShelfZoom").GetComponent<ShelfClicked>();
    }

    public void EnterBasement(){
        Room1M.camra.transform.position = Basement1;
    }

    public void OpenBox(){
        Room1M.camra.transform.position = ElectricalBox;
    }
    public void EnterBasement2(){
        Room1M.camra.transform.position = new Vector3(960f, -2700f, -10f);
        Room1M.camra.GetComponent<Camera>().orthographicSize= CameraSizeNormal;
    }
    public void BoxPuzzleZoom(){
        Room1M.camra.transform.position = BoxPuzzle;
        Room1M.camra.GetComponent<Camera>().orthographicSize= CameraSizeBoxP;
    }
    public void EnterHallway(){
        Room1M.camra.transform.position = Hallway;
        
    }        
}
