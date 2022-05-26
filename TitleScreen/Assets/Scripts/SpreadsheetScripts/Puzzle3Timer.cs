using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Puzzle3Timer : MonoBehaviour
{
    public Pickup pickupscript;

    void Awake(){
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();

    }

    private float time = 0.0f;
    private string timer = "";
    private int clicks = 0;

    public InputField mainInputField;

    [SerializeField] InputField feedback1;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSckfvAf6W5IDYroE8crKsB7s1LVzpHpboKajBt4N8fcoQVBdw/formResponse";

    void Update()
    {
        time += Time.deltaTime;
        timer = time.ToString();
    }

    public void Send()
    {
        if (pickupscript.Room2Access == true){
            clicks += 1;
            if (clicks == 1){
                mainInputField.text = timer;
            }
        }
    }
} 