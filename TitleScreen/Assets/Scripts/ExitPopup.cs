using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPopup : MonoBehaviour
{
   public GameObject CPpop; //popup prefab
   private GameObject CPpopCLONE; //instantiated prefab
 

   public void openPopup(){
       CPpopCLONE = Instantiate(CPpop, GameObject.Find("Popup").transform, false);
   }

   public void closePopup(){
       Debug.Log("won't destroy");
       Destroy(CPpopCLONE);
   }
}
