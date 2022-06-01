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
    [SerializeField] InputField puzzle4;
    [SerializeField] InputField puzzle5;
    [SerializeField] InputField puzzle6;
    [SerializeField] InputField puzzle7;
    [SerializeField] InputField puzzle8;
    [SerializeField] InputField puzzle9;
    [SerializeField] InputField feedback;


    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSckfvAf6W5IDYroE8crKsB7s1LVzpHpboKajBt4N8fcoQVBdw/formResponse";

    public void Send()
    {
        StartCoroutine(Post(UsernameScript.enteredusername, puzzle1.text, puzzle2.text, puzzle3.text, puzzle4.text, puzzle5.text, puzzle6.text, puzzle7.text, puzzle8.text, puzzle9.text, feedback.text));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator Post(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10, string s11)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1276959385", s1);
        form.AddField("entry.1996965476", s2);
        Debug.Log("it work");
        form.AddField("entry.660436114", s3);
        form.AddField("entry.170883059", s4);
        form.AddField("entry.673413182", s5);
        form.AddField("entry.242230946", s6);
        form.AddField("entry.758704215", s7);
        Debug.Log("why");
        form.AddField("entry.1271121528", s8);
        form.AddField("entry.832602513", s9);
        form.AddField("entry.1113452384", s10);
        form.AddField("entry.1702207418", s11);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        
        yield return www.SendWebRequest();
    }
}