using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour
{
    //the Meshrenderer on the current Main Menu object
    MeshRenderer thisOne;

    public static bool menuActive = false;

    // Start is called before the first frame update
    void Start()
    {
        thisOne = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuActive = !menuActive;
        }

        setMeshRender();
    }

    void setMeshRender()
    {
        thisOne.enabled = menuActive;
    }
}
