using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinDetectScript : MonoBehaviour
{
    //for timer purposes
    private GameObject obj1;

    void Awake()
    {
        obj1 = GameObject.FindGameObjectWithTag("Timer");
    }

    private float time = 0.0f;
    private string timer = "";

    public InputField mainInputField;

    [SerializeField] InputField feedback1;

    void Update()
    {
        time = Mathf.Abs(1800 - obj1.GetComponent<Clock>().timetodisplay);
        timer = time.ToString();
    }

    //actual win detect code
    public Pickup pickupscript;
    public GameObject basementSequence;
    public GameObject boxZoom;
    public Room2Movement move;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.layer == 8)
        {
            WinBoxes();
            
        }
    }
    
    public void WinBoxes(){
        pickupscript.ItemToInv(basementSequence);
        move.EnterBasement2();
        boxZoom.SetActive(false);
        mainInputField.text = timer;
        Debug.Log(timer);
    }

    // Start is called before the first frame update
    void Start()
    {
        pickupscript = GameObject.Find("PickupScript").GetComponent<Pickup>();
        boxZoom = GameObject.Find("Boxes");
        move = GameObject.Find("Room2").GetComponent<Room2Movement>();
    }
}
