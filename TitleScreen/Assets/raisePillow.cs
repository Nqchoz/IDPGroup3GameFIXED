using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raisePillow : MonoBehaviour
{
    public GameObject MovedPillow;

    void Awake(){
        MovedPillow = GameObject.Find("MovedPillow");
        MovedPillow.SetActive(false);
    }

    public void pillowSearched(){
        MovedPillow.SetActive(true);
        gameObject.SetActive(false);
    }
}
