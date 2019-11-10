using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public static bool inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectiveManager.currentObjective >= 9)
            inventory = false;
    }
}
