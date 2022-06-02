using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    
    public CanvasGroup fadeImage;
    public GameObject fader;


    public void winFade(){
        fader.SetActive(true);
        StartCoroutine(Fade());
    }

    IEnumerator Fade(){
        Debug.Log("winner winner");
        while(fadeImage.alpha < 1){
            fadeImage.alpha += (float)0.15;
            yield return new WaitForSeconds((float)0.03);
        }
        SceneManager.LoadScene(5);
        
    }
}
