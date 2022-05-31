using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Puzzle9Script : MonoBehaviour
{
    private GameObject obj1;

    void Awake()
    {
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
        clicks += 1;
        if (clicks == 1)
        {
            mainInputField.text = timer;
        }
    }
}