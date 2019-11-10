using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Material system, person;

    public static MeshRenderer newRenderer;

    public string message;

    Text textObj;

    // Start is called before the first frame update
    void Start()
    {
        newRenderer = gameObject.GetComponent<MeshRenderer>();
        textObj = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMessage(string m_message)
    {
        message = m_message;
    }

    public  void EnableMesh()
    {
        newRenderer.enabled = true;
        textObj.text = message;
    }

    public void DisableMesh()
    {
        newRenderer.enabled = false;
    }

    public void NextMessage(string next)
    {
        newRenderer.material = person;
        message = next;
        textObj.text = message;
    }

    public void ResetMessages()
    {
        newRenderer.material = system;
        newRenderer.enabled = false;
        textObj.text = "";
    }
}
