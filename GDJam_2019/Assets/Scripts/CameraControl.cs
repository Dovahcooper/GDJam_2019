using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    #region variables
    [HideInInspector]
    public Vector3 ForwardCast;
    [HideInInspector]
    public Vector3 RightCast;

    public int rotateSpeed;

    public Vector3 origin = new Vector3(0.0f, 0.9f, 0.0f);

    [HideInInspector]
    public Vector2 cameraLook;

    public bool connected;
    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        rotateSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //if(!MenuStart.menuActive)
        mouseUpdate();

        //rotateSpeed = Mathf.Clamp(rotateSpeed, 1, 10);

        cameraLook.y = Mathf.Clamp(cameraLook.y, -80.0f, 60.0f);

        Quaternion cameraRotate = Quaternion.Euler(-cameraLook.y, cameraLook.x, 0.0f);
        transform.rotation = cameraRotate;

        //ForwardCast = -GetComponentInChildren<CameraClipping>().noClipPositionBehind;
        //RightCast = GetComponentInChildren<CameraClipping>().noClipPositionRight;

        //transform.localPosition = Vector3.MoveTowards(transform.localPosition, origin, 240 * Time.deltaTime);
    }

    void mouseUpdate()
    {
        cameraLook.x += Input.GetAxis("Mouse X") ;//* rotateSpeed;
        cameraLook.y += Input.GetAxis("Mouse Y"); //* rotateSpeed;
    }

    void OnDestroy()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}