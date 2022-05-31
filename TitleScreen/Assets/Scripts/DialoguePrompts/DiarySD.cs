using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiarySD : MonoBehaviour
{

    
    public startDialogue sD; //startDialogue script\
    public bool OpenedD;
    public bool FoundD;

    void Awake(){
        sD = GameObject.Find("Dialogue").GetComponent<startDialogue>();
        FoundD = false;
    }

    public void startDiary(){
        FoundD = true;
        sD.MakeDialogue(GameObject.Find("Diary1").GetComponent<Dialogue>(), new string[] {"Oh. My old diary…", "Welp, it's locked. I don't remember the code… ", "Ugh, there's gotta be something around here that'll help me remember."});
    }

    public void openDiary(){
        OpenedD = true;
        sD.MakeDialogue(GameObject.Find("OpenDiary1").GetComponent<Dialogue>(), new string[] {"Now let's see.", " Maybe I had written something about the music box handle."});
    }
    
    public void HandleD(){
        sD.MakeDialogue(GameObject.Find("HandleDialogueScript").GetComponent<Dialogue>(), new string[] {"I can't remember why, but I love this song. ", "Wait...",  "why does the music sound so weird?", "Maybe the box is more broken than I thought. Maybe if I can open it up I could fix it."});
    }
}
