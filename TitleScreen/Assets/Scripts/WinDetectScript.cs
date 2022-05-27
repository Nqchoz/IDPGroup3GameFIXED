using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetectScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.layer == 6)
        {
            Debug.Log("you won");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
