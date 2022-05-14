using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public text timeText;
    public int time;
    public TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Mathf.RoundToInt(Time.deltaTime);
        timeText.text = time.ToString();
    }
}
