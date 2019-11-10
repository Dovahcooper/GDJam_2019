using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public static Objective objective;

    public static Person deliverable;

    private string[] giftLines;

    private Items[] objectiveList = new Items[10];

    [HideInInspector]
    public static int currentObjective;

    // Start is called before the first frame update
    void Start()
    {
        currentObjective = 0;

        for(int i = 0; i < 10; i++)
        {
            objectiveList[i] = (Items)Random.Range(0, (int)Items.maxItems);
        }
    }

    // Update is called once per frame
    void Update()
    {
        deliverable.setPersonType((int)objectiveList[currentObjective]);
    }

    public static void nextObjective()
    {
        deliverable = PeopleManager.GetPerson(++currentObjective);
    }
}
