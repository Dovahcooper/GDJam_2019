using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Material system, person;

    public static MeshRenderer renderer;

    string message;

    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<MeshRenderer>();
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
    }

    public void DisableMesh()
    {
        renderer.enabled = false;
    }

    public void NextMessage(string next)
    {
        renderer.material = person;
        message = next;
    }

    public void ResetMessages()
    {
        renderer.material = system;
        renderer.enabled = false;
    }
}
