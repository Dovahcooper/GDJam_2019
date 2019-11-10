using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    secondDialogue,
    reward,
    Exit
}

public class Person : MonoBehaviour
{
    public string systemDialogue;
    public string personDialogue;
    public const string personDialogue2 = "Thank you for the package, here, take this";
    public string systemDialogue2;
    public string personName;

    public string[] names;
    public string[] gifts;

    public static PeopleTypes personType;
    public PersonState state = PersonState.noDialogue;

    public static string[] itemNames;

    public Canvas npcDialogue;
    public Text npc_name;
    public Text npcText;

    public Canvas systemMessage;
    public Text displayText;

    public Animator playerAnimator;

    public ParticleSystem hearts;

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
        names = new string[(int)Items.maxItems]{
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "Edward",
            "",
            "",
            "Miner",
            "Mr Potato Head",
            "Santa",
            "Sauron",
            "Game Dev",
            ""
        };
        gifts = new string[(int)Items.maxItems]{
            "Over 3000 dollars",
            "Diamonds",
            "The keys to their new car",
            "A free mansion that never belonged to Luigi",
            "The newest iPhone",
            "A hot single girl in your area",
            "Friendship",
            "A new gaming pc",
            "Josh",
            "GD Socks",
            "Sans Undertale",
            "The battle bus",
            "The philosophers stone",
            "A coupon for a free carriage ride across the Skyrim border",
            "Free real estate",
            "That one song that gets stuck in your head"
        };

        npcDialogue = GameObject.Find("Dialogue_Box_Display").GetComponent<Canvas>();
        systemMessage = GameObject.Find("System_Msg_Display").GetComponent<Canvas>();

        npc_name = GameObject.Find("Name").GetComponent<Text>();
        npcText = GameObject.Find("Dialogue").GetComponent<Text>();
        displayText = GameObject.Find("SystemDialogue").GetComponent<Text>();

        playerAnimator = GameObject.Find("Player").GetComponent<Animator>();

        hearts = GetComponentInChildren<ParticleSystem>();

        state = PersonState.noDialogue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPosition(Vector3 position)
    {
        transform.position = position;
    }

    public void setPersonType(int a_personType)
    {
        personType = (PeopleTypes)a_personType;
    }

    public void setDialogue(string[] receiveDialogue)
    {
        systemDialogue = "You delivered The " + itemNames[(int)personType] + "!";
        personDialogue = receiveDialogue[(int)personType];
        systemDialogue2 = "They tried to give you: " + gifts[(int)personType] + ". but this gift cannot be given because your inventory is full.";
        personName = names[(int)personType];
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    if(Input.GetKeyUp(KeyCode.Space))
    //    {
    //        switch (state)
    //        {
    //            case PersonState.noDialogue:
    //                GetComponentInChildren<Dialogue>().SetMessage(systemDialogue);
    //                GetComponentInChildren<Dialogue>().EnableMesh();
    //                state++;
    //                break;
    //            case PersonState.firstDialogue:
    //                GetComponentInChildren<Dialogue>().NextMessage(personDialogue);
    //                state++;
    //                break;
    //            case PersonState.secondDialogue:
    //                GetComponentInChildren<Dialogue>().DisableMesh();
    //                GetComponentInChildren<Dialogue>().ResetMessages();
    //                ObjectiveManager.nextObjective();
    //                state = PersonState.noDialogue;
    //                break;
    //            default:
    //                break;
    //        }
    //    }
    //}

    private void DisplayDialogue(PersonState a, string dia, string name)
    {
        systemMessage.enabled = false;
        npcDialogue.enabled = false;

        displayText.text = dia;

        npc_name.text = name;
        npcText.text = dia;

        switch (a)
        {
            case PersonState.noDialogue:
                MenuManager.activeDialogue = true;
                systemMessage.enabled = true;
                state = PersonState.firstDialogue;
                playerAnimator.Play("Bow");
                break;
            case PersonState.firstDialogue:
                npcDialogue.enabled = true;
                state = PersonState.secondDialogue;
                break;
            case PersonState.secondDialogue:
                npcDialogue.enabled = true;
                state = PersonState.reward;
                break;
            case PersonState.reward:
                systemMessage.enabled = true;
                state = PersonState.Exit;
                break;
            case PersonState.Exit:
                state = PersonState.noDialogue;
                hearts.Play();
                MenuManager.activeDialogue = false;
                ObjectiveManager.nextObjective();
                break;
        }
    }

    public void checkPlayer(Vector3 player_pos)
    {
        float magnitude = Vector3.Magnitude(player_pos - transform.position);
        if (magnitude <= 4.5)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (state == PersonState.noDialogue)
                {
                    DisplayDialogue(state, systemDialogue, "");
                }
                else if (state == PersonState.firstDialogue)
                {
                    DisplayDialogue(state, personDialogue, personName);
                }
                else if (state == PersonState.secondDialogue)
                {
                    DisplayDialogue(state, personDialogue2, personName);
                }
                else if(state == PersonState.reward)
                {
                    DisplayDialogue(state, systemDialogue2, personName);
                }
                else
                {
                    DisplayDialogue(state, "", "");
                }

                Debug.Log("The current state is " + state);
            }
        }
    }

    public void setLast()
    {
        systemDialogue2 = "They gave you: A Crusty Sock. but this gift cannot be given because your inventory is full.";
    }
}
