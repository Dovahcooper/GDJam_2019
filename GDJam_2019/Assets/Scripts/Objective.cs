using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Kaylyn, put the items that can be picked from here, before the maxItems thing
Any item will always be serialized, cause I defaulted the first one to zero,
so it will match with the corresponding value in the Person.cs file
*/
public enum Items
{
    strawberry = 0,
    lightbulb,
    screwdriver,
    sword,
    tapshoes,
    stapler,
    pizza,
    violin,
    sunglasses,
    cat,
    pickaxe,
    potato,
    coal,
    ring,
    duck,
    elevator,
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
