using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMEnu : MonoBehaviour
{
    
    public Canvas canvas;
    public bool showing = false;
    public GameObject obj;

    void Awake(){
        obj = GameObject.FindGameObjectWithTag ("Timer");

    }
    
    public void ExitToMenu()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void popup(){

        if (showing == false){

            showing = true;
            canvas.enabled = showing;
            obj.GetComponent<Clock> ().timerpower = false;
        }

        else if (showing == true){

            showing = false;
            canvas.enabled = showing;
            obj.GetComponent<Clock> ().timerpower = true;
        }
        




    }
}
