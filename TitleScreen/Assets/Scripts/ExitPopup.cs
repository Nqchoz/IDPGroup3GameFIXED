using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPopup : MonoBehaviour
{
   public GameObject CPpop; //popup prefab
   public GameObject CPpopCLONE; //instantiated prefab
   public GameObject Sequence; //popup prefab
   private GameObject SequenceCLONE; //instantiated prefab

   public void openPopup(){
       CPpopCLONE = Instantiate(CPpop, GameObject.Find("Popup").transform, false);
   }

   public void closePopup(){
       Destroy(CPpopCLONE);
       Debug.Log(CPpopCLONE);
   }
   public void openSequence(){
       SequenceCLONE = Instantiate(Sequence, GameObject.Find("Popup").transform, false);
   }
   public void closeSequence(){
       Debug.Log("won't destroy");
       Destroy(SequenceCLONE);
   }
}
