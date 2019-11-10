using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Material system, person;

    public static MeshRenderer renderer;

    string message;

    Text textObj;

    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<MeshRenderer>();
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
        renderer.enabled = true;
        textObj.text = message;
    }

    public void DisableMesh()
    {
        renderer.enabled = false;
    }

    public void NextMessage(string next)
    {
        renderer.material = person;
        message = next;
        textObj.text = message;
    }

    public void ResetMessages()
    {
        renderer.material = system;
        renderer.enabled = false;
        textObj.text = "";
    }
}
