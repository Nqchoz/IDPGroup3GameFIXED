using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{ 
    
    public Grid grid;
    public int colorVar; //variable to make the prefab
    public bool enabledVar;
    public Canvas canvas;

    

    //0Empty
    //1Red
    //2Yellow
    //3Blue
    //4Green
    //5Orange


    void Awake(){
        grid = GameObject.Find("FlowPuzzleCanvas").GetComponent<Grid>();
        enabledVar=false;
        canvas = GameObject.Find("FlowPuzzleCanvas").GetComponent<Canvas>();
        
    }
    void OnMouseDrag(){
        for (int y = 0; y <5; y++){
            for (int x = 0; x < 5; x++){
               
               if (GetMousePos().x <= Mathf.RoundToInt((grid.board[x,y].transform.position.x/(float)10)+3) && GetMousePos().x >= Mathf.RoundToInt((grid.board[x,y].transform.position.x/(float)10)-3)
               && GetMousePos().y == Mathf.RoundToInt(grid.board[x,y].transform.position.y/(float)100.7))
                {
                    for (int i = 6; i <11; i++){   
                        if (grid.gameboard[x,y] == i&& enabledVar == false){
                            colorVar = i-5;
                            enabledVar = true;
                            for (int y2 = 0; y2 <5; y2++){
                                for (int x2 = 0; x2 < 5; x2++){
                                    if (grid.gameboard[x2,y2] == i-5){
                                        grid.gameboard[x2,y2] = 0;
                                    }
                                }
                            }
                            
                        }
                        if(enabledVar == true && grid.gameboard[x,y] == 0){
                            grid.gameboard[x,y] = colorVar;
                        }
                        else if (enabledVar == true && grid.gameboard[x,y] >= 6 && grid.gameboard[x,y] != (colorVar +5) ){
                            Debug.Log(grid.gameboard[x,y].ToString() + " = " + (colorVar+5).ToString());
                            enabledVar = false;
                        }
                    }    
               }   
          }
       }
        
    }
    void OnMouseUp(){
        enabledVar = false;
    }
    Vector3 GetMousePos(){
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        mousePos.x = Mathf.RoundToInt(mousePos.x/10);
        mousePos.y = Mathf.RoundToInt(mousePos.y/100);
        return mousePos;
    }

     
        
        
    

}
