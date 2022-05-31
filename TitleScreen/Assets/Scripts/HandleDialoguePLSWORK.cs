using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleDialoguePLSWORK : MonoBehaviour
{
    public startDialogue stardD;

    void Awake(){
        stardD = GameObject.Find("HandleDialogueScript").GetComponent<startDialogue>();
    }
    public void HandleDialogue(){
        stardD.MakeDialogue(GameObject.Find("HandleDialogueScript").GetComponent<Dialogue>(), new string[] {"I can't remember why, but I love this song. ", "Wait...",  "why does the music sound so weird?", "Maybe the box is more broken than I thought. Maybe if I can open it up I could fix it."});
    }
}
