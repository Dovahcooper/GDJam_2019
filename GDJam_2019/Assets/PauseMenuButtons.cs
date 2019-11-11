using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuButtons : MonoBehaviour
{
    public Canvas pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shutdown()
    {
        Application.Quit(0);
    }

    public void Resume()
    {
        Debug.Log("clicked!");
        pauseMenu.enabled = false;
        MenuManager.paused = false;
    }

}
