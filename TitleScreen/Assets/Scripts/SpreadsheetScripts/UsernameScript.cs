using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UsernameScript : MonoBehaviour
{

    [SerializeField] InputField feedback1;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSckfvAf6W5IDYroE8crKsB7s1LVzpHpboKajBt4N8fcoQVBdw/formResponse";

    
    public void Send()
    {
        StartCoroutine(Post(feedback1.text));
        SceneManager.LoadScene(2);
    }

    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1276959385", s1);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        
        yield return www.SendWebRequest();
    }
}