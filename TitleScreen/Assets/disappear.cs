using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disappear : MonoBehaviour
{
    public void disappears(){
        gameObject.GetComponent<Button>().enabled = false;
    }
}
