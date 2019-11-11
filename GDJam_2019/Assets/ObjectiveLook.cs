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
        Vector3 tempVec = PeopleManager.GetPerson(ObjectiveManager.currentObjective).transform.position;

        Vector3 swizzle = -(tempVec - transform.position);

        LookAt = transform.position + swizzle;

        LookAt.y = transform.position.y;

        transform.LookAt(LookAt);
    }
}
