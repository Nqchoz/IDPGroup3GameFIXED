using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Movement : MonoBehaviour
{
    public Vector3[] Rooms;
    public int currentRoom;
    public ShelfClicked Room1M;

    void Awake(){
        Room1M = GameObject.Find("ShelfZoom").GetComponent<ShelfClicked>();
        Rooms = new Vector3[] {new Vector3(2880f, -540f, -10f), new Vector3(2880f, -1620f, -10f), new Vector3(2880f, -2700f, -10f), new Vector3(2880f, -3780f, -10f)};
        currentRoom = 3;
    }

    public void NextRoom(){
        if (currentRoom <3){
            currentRoom ++;
        }
        else{
            currentRoom = 0;
        }
        Room1M.camra.transform.position = Rooms[currentRoom];
    }
    public void BackRoom(){
        if (currentRoom >0){
            currentRoom --;
        }
        else{
            currentRoom = 3;
        }
        Room1M.camra.transform.position = Rooms[currentRoom];
    }
    public void EnterRoom3(){
        Room1M.camra.transform.position = Rooms[currentRoom];
    }


}
