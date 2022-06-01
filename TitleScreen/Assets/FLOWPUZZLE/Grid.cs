using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    //for spreadsheet purposes
    private GameObject obj1;

    void Awake()
    {
        obj1 = GameObject.FindGameObjectWithTag("Timer");
    }

    private float time = 0.0f;
    private string timer = "";

    public InputField mainInputField;

    [SerializeField] InputField feedback1;

    public enum Colors{
        Empty,
        Red,
        Yellow,
        Blue,
        Green,
        Orange

    }
   public int[,] winboard = {{8,1,1,6,10},{3,1,2,7,5},{3,1,7,5,5},{3,6,10,5,9},{3,8,9,4,4}}; 
   public int[,] gameboard = {{8,0,0,6,10},{0,0,0,7,0},{0,0,7,0,0},{0,6,10,0,9},{0,8,9,0,0}};
   public GameObject[,] board = new GameObject[5,5];
   public GameObject[] linePrefs;
   private int gridsquare;
   private int isArrayEqual;
   private GameObject[,] testingClones = new GameObject[5,5];
   public Room2Movement Room2M;
   public Sprite lightsOn;
   public Image Basement1Image;
   public GameObject Basement2_1Access;
   public bool didwin;
   public GameObject ElectricalBox;

   void Start(){
       ClearBoard();
       Room2M = GameObject.Find("Room2").GetComponent<Room2Movement>();
       Basement1Image = GameObject.Find("Basement1_1").GetComponent<Image>();
       Basement2_1Access = GameObject.Find("Basement1_1 Back");
       Basement2_1Access.GetComponent<Image>().color = new Color (255, 255, 255, 0);
       Basement2_1Access.GetComponent<Button>().enabled = false;
       ElectricalBox = GameObject.Find("ElectricalBox");
       didwin = false;
   }
   void Update(){
        time = Mathf.Abs(1800 - obj1.GetComponent<Clock>().timetodisplay);
        timer = time.ToString();
        if (didwin != true){
            UpdateGameBoard();
            if (isArrayEqual == 25){
                win();
            }
       }
       
   }
    public void UpdateGameBoard(){
        isArrayEqual = 0;
        for (int y = 0; y <5; y++){
            for (int x = 0; x < 5; x++){
                Destroy(testingClones[x,y]);
                testingClones[x,y] = Instantiate(linePrefs[gameboard[x,y]], board[x,y].transform, false);
           }
        }
        for (int y = 0; y <5; y++){
            for (int x = 0; x < 5; x++){
	    	    
	    		if (winboard[x, y] != gameboard[x, y]) {
	    			break;
	        	}
                else{
                    isArrayEqual ++;
                }
            }
        }
       
    }
    public void ClearBoard(){
        gridsquare = 1;
        for (int y = 0; y <5; y++){
            for (int x = 0; x < 5; x++){
                board[x, y] = GameObject.Find("GridSquare ("+gridsquare.ToString()+")");
                gridsquare++;
            }
        }
    }

    public void win(){
        Room2M.EnterBasement();
        Basement1Image.GetComponent<Image>().color = new Color(255, 255, 255, 100);
        Basement2_1Access.GetComponent<Image>().color = new Color (255, 255, 255, 100);
        Basement2_1Access.GetComponent<Button>().enabled = true;
        didwin = true;
        mainInputField.text = timer;
        Debug.Log(timer);
        ElectricalBox.SetActive(false);
    }



}

//0049FF Blue
//009818 green
//FF5700 orange
//FF0000 red
//8CFF00 yellow