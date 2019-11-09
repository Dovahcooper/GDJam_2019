using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Kaylyn, put the items that can be picked from here, before the maxItems thing
Any item will always be serialized, cause I defaulted the first one to zero,
so it will match with the corresponding value in the Person.cs file
*/
enum Items
{
    television = 0,
    audioSystem,

    maxItems,
}

public class Objective : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
