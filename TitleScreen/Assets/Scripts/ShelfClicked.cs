using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfClicked : MonoBehaviour
{

    public GameObject camera;
    public GameObject GameUI;

    void Awake(){
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        GameUI = GameObject.FindGameObjectWithTag("GUI");
        
    }

    public void Shelf_1Zoom()
    {
        Debug.Log("Registered Click");
        camera.transform.position += new Vector3(0, 1920.0f, 0);
        GameUI.transform.position += new Vector3(0, 1920.0f, 0);
        
    }

}
