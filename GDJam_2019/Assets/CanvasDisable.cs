using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDisable : MonoBehaviour
{
    Canvas canv;

    // Start is called before the first frame update
    void Start()
    {
        canv = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        canv.enabled = MenuStart.menuActive;
    }
}
