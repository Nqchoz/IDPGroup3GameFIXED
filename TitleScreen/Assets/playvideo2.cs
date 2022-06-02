using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playvideo2 : MonoBehaviour
{
    public VideoPlayer videoPlayer1;
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
        yield return new WaitForSeconds(25f);
        SceneManager.LoadScene(3);

    }
}
