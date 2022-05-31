using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Puzzle3Timer : MonoBehaviour
{
    public Pickup pickupscript;
    private GameObject obj1;

    void Awake(){
        pickupscript = GameObject.FindGameObjectWithTag("pickupscript").GetComponent<Pickup>();
        obj1 = GameObject.FindGameObjectWithTag("Timer");
    }

    private float time = 0.0f;
    private string timer = "";
    private int clicks = 0;

    public InputField mainInputField;

    [SerializeField] InputField feedback1;

    void Update()
    {
        time = Mathf.Abs(1800 - obj1.GetComponent<Clock>().timetodisplay);
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