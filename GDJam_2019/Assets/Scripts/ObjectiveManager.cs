using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public static Objective objective;

    public static GameObject deliverable;

    private string[] giftLines;

    private Items[] objectiveList = new Items[10];

    [HideInInspector]
    public static int currentObjective;

    public Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        currentObjective = 0;

        for(int i = 0; i < 10; i++)
        {
            objectiveList[i] = (Items)Random.Range(0, (int)Items.maxItems);
        }

        deliverable = PeopleManager.GetPerson(currentObjective);
    }

    // Update is called once per frame
    void Update()
    {
        deliverable.GetComponent<Person>().setPersonType((int)objectiveList[currentObjective]);
        deliverable.GetComponent<Person>().checkPlayer(playerPos.position);

        
    }

    public static void nextObjective()
    {
        if (currentObjective < 9)
            deliverable = PeopleManager.GetPerson(++currentObjective);
        else
            currentObjective = 10;
    }
}
