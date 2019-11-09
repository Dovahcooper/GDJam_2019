using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Kaylyn, put in people types here to correspond with the people in the other  
*/
public enum PeopleTypes
{
    strawberry = 0,
    power,
    bookshelf,
    renaissance,
    recital,
    vsco,
    buffet,
    scissorhand,
    vampire,
    allergic,
    diamond,
    potato,
    santa,
    sauron,
    programmer,
    bungalow
}

public class Person : MonoBehaviour
{
    [HideInInspector]
    public static string systemDialogue;
    public static string personDialogue;

    public static PeopleTypes personType;

    public static string[] itemNames;

    // Start is called before the first frame update
    void Start()
    {
        itemNames = new string[(int)Items.maxItems]{
            "Strawberry Shortcake",
            "Lightbulbs",
            "Screwdriver",
            "Sword",
            "Tap Shoes",
            "Stapler",
            "Pizza",
            "Violin",
            "Sunglasses",
            "Cat",
            "Pickaxe",
            "Potato",
            "Coal",
            "One Ring",
            "Rubber Ducky",
            "Elevator"
            };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void setDialogue(string receiveDialogue)
    {
        systemDialogue = "You delivered The " + itemNames[(int)personType] + "!";
        personDialogue = receiveDialogue;
    }
}
