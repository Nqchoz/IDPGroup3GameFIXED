using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clock : MonoBehaviour
{
    public Text timerText;
    public int time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Mathf.RoundToInt(Time.deltaTime);
        timerText.text = time.ToString();
    }
}
