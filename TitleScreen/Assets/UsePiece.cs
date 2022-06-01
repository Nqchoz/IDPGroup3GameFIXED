using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePiece : MonoBehaviour
{
    public PuzzlePieces puzzlepieces;
    public int pieceNum;

    void Awake(){
        puzzlepieces = GameObject.Find("PuzzlePiecesScript").GetComponent<PuzzlePieces>();
    }
    public void used(){
        puzzlepieces.AttachPiece(pieceNum);
    }
    
}
