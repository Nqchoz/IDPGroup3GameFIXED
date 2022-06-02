using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayVideo : MonoBehaviour
{


    public VideoPlayer videoPlayer1;
    public VideoClip video2;
    public GameObject panel;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVid());
    }

    IEnumerator PlayVid(){
        videoPlayer1.Prepare();
        WaitForSeconds wait = new WaitForSeconds(1);
        while (!videoPlayer1.isPrepared){
            yield return wait;
            break;
        }
        
        panel.SetActive(false);
        
        videoPlayer1.Play();
        yield return new WaitForSeconds(89f);

        videoPlayer1.clip = video2;
        while (!videoPlayer1.isPrepared){
            yield return wait;
            break;
        }
        videoPlayer1.Play();
        yield return new WaitForSeconds(70);
        SceneManager.LoadScene(1);

    }
    

   
}
