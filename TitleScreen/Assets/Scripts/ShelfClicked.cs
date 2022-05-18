using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfClicked : MonoBehaviour
{

    public GameObject camera;

    void Awake(){
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void OnMouseDown()
    {
        Debug.Log("Registered Click");
        camera.transform.position += new Vector3(0, 1920.0f, 0);
        
    }

}
