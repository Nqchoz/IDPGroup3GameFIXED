using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UsernameScript : MonoBehaviour
{

    [SerializeField] InputField feedback1;

    public static string enteredusername;

    
    public void Send()
    {
        enteredusername = feedback1.text;
        SceneManager.LoadScene(2);
    }

    
}