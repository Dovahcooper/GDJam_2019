using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    
    public Canvas pauseMenu;
    public Canvas npcDialogue;
    public Canvas systemMessage;

    //A global variable, no other GUI should be able to enable if this is true.
    public static bool paused = false;
    public static bool activeDialogue = false;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.enabled = false;
        npcDialogue.enabled = false;
        systemMessage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Press Escape for pause menu!
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (pauseMenu.enabled)
            {
                
                pauseMenu.enabled = false;

                paused = false;
                
            }
            else if (!pauseMenu.enabled && !activeDialogue)
            {
                pauseMenu.enabled = true;
                paused = true;

            }
        }
    }

   


}


