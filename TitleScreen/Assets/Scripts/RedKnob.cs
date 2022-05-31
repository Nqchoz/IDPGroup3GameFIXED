using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKnob : MonoBehaviour
{
    public Dragger dragger;
    public Grid grid;

    void Awake(){
        grid = GameObject.Find("FlowPuzzleCanvas").GetComponent<Grid>();
        dragger = GameObject.Find("FlowPuzzleCanvas").GetComponent<Dragger>();
    }

   public void redKnob(){
       for (int y = 0; y <5; y++){
            for (int x = 0; x < 5; x++){
                if (grid.gameboard[x,y] == 1){
                    grid.gameboard[x,y] = 0;
                }
           }
        }
        dragger.enabledVar = true;
        dragger.colorVar = 1;
    }

}
