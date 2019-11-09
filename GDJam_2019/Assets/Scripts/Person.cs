using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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

public enum PersonState
{
    noDialogue = 0,
    firstDialogue,
    secondDialogue
}

public class Person : MonoBehaviour
{
    [HideInInspector]
    public static string systemDialogue;
    public static string personDialogue;

    public static PeopleTypes personType;
    PersonState state = PersonState.noDialogue;

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

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                switch (state)
                {
                    case PersonState.noDialogue:
                        GetComponentInChildren<Dialogue>().SetMessage(systemDialogue);
                        GetComponentInChildren<Dialogue>().EnableMesh();
                        state++;
                        break;
                    case PersonState.firstDialogue:
                        GetComponentInChildren<Dialogue>().NextMessage(personDialogue);
                        state++;
                        break;
                    case PersonState.secondDialogue:
                        GetComponentInChildren<Dialogue>().DisableMesh();
                        GetComponentInChildren<Dialogue>().ResetMessages();
                        state = PersonState.noDialogue;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
