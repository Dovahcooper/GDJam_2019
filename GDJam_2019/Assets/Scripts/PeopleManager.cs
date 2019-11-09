using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleManager : MonoBehaviour
{
    string[] dialogue;

    Person[] people;

    const int numPeople = 25;

    // Start is called before the first frame update
    void Start()
    {
        //put all the dialogue options here
        //please god, do it.
        dialogue = new string[(int)Items.maxItems]{
            "",
            ""
        };

        people = new Person[numPeople];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public Person GrabPerson()
    {
        int random = Random.Range(0, numPeople);

        return people[random];
    }
}
