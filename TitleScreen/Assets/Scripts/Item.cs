using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType{
        Hint,
        Flashlight,
        Handle,
        Screwdriver,

    }

    public ItemType itemType;

}
