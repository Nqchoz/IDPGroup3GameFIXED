using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SendData: MonoBehaviour
{
    [SerializeField] InputField enteredusername;
    [SerializeField] InputField puzzle1;
    [SerializeField] InputField puzzle2;
    [SerializeField] InputField puzzle3;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSckfvAf6W5IDYroE8crKsB7s1LVzpHpboKajBt4N8fcoQVBdw/formResponse";

    public void Send()
    {
        StartCoroutine(Post(UsernameScript.enteredusername, puzzle1.text, puzzle2.text, puzzle3.text));
    }

    IEnumerator Post(string s1, string s2, string s3, string s4)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1276959385", s1);
        form.AddField("entry.1996965476", s2);
        form.AddField("entry.660436114", s3);
        form.AddField("entry.170883059", s4);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        
        yield return www.SendWebRequest();
    }
}