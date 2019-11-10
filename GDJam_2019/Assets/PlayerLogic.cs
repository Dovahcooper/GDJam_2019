using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLogic : MonoBehaviour
{
    public static bool inventory;

    public RawImage inventorySlot;

    public Texture parcel, sock;

    // Start is called before the first frame update
    void Start()
    {
        inventorySlot = GameObject.Find("Inventory").GetComponent<RawImage>();
        inventory = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectiveManager.currentObjective >= 9)
            inventory = false;

        if(inventory)
        {
            inventorySlot.texture = parcel;
        }
        else
        {
            inventorySlot.texture = sock;
        }
    }
}
