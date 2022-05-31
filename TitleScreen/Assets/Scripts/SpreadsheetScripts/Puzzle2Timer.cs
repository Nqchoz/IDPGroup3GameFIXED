using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Puzzle2Timer : MonoBehaviour
{
    private float time = 0.0f;
    private string timer = "";
    private int click = 0;
    private GameObject obj1;


    public InputField mainInputField;

    [SerializeField] InputField feedback1;

    void Awake()
    {
        obj1 = GameObject.FindGameObjectWithTag("Timer");
    }

    void Update()
    {
        time = Mathf.Abs(1800 - obj1.GetComponent<Clock>().timetodisplay);
        timer = time.ToString();
    }

    public void Send()
    {
        click += 1;
        if (click == 1)
        {
            mainInputField.text = timer;
        }
    }
}