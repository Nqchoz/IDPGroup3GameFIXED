using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundPiece : MonoBehaviour
{
    public PuzzlePieces script1; //puzzle pieces script
    public int PieceNum;

    void Awake(){
        script1 = GameObject.Find("PuzzlePiecesScript").GetComponent<PuzzlePieces>();
    }

    public void PieceClicked(){
        script1.FoundPiece(PieceNum, gameObject);
    }
    
}
