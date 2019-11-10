using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveLook : MonoBehaviour
{
    public Vector3 LookAt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAt = PeopleManager.GetPerson(ObjectiveManager.currentObjective).transform.position;
        transform.LookAt(LookAt);
    }
}
