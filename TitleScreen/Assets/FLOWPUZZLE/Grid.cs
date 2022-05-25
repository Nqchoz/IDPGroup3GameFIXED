using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Grid : MonoBehaviour
{
    public enum Colors{
        Empty,
        Red,
        Yellow,
        Blue,
        Green,
        Orange

    }
   public int[,] winboard = {{3,1,1,1,5},{3,1,2,2,5},{3,1,2,5,5},{3,1,5,5,4},{3,3,4,4,4}}; 
   public int[,] gameboard = {{3,0,0,1,5},{0,0,0,2,0},{0,0,2,0,0},{0,1,5,0,4},{0,3,4,0,0}};
   public GameObject[,] board;
   public GameObject[] linePrefs;

  
}
