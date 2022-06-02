using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openCabinet : MonoBehaviour
{
    public GameObject cabOpen;
    public GameObject cabClosed;

    public void openCab(){
        cabOpen.SetActive(true);
        cabClosed.SetActive(false);
        
    }
}
