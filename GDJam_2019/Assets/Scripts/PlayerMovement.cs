using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NewMath;

public class PlayerMovement : MonoBehaviour
{
    #region variables
    public const float speed = 35f;

    [HideInInspector]
    public bool Jumping;

    [HideInInspector]
    public bool canJump;
    
    public Rigidbody rb;

    public float firstJump;
    private float secondJump;

    public Vector2 moveInput;

    //public Buttons JumpButton;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        firstJump = 10f;

        //transform.position = new Vector3(0, 70, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();

        secondJump = firstJump * 0.75f;

        if(!MenuStart.menuActive)
            KeyboardMovement();

        //JumpLogic();
        
        //KeyboardFunctions();
    }

    //void ControllerFunctions()
    //{
    //    if (!Grapple.Grappling)
    //    {
    //        ControllerMovement();
    //        ControllerJumping();
    //    }
    //
    //    if (XInput.GetKeyPressed(0, (int)Buttons.Start))
    //        Application.Quit(1);
    //}

    //void KeyboardFunctions()
    //{
    //    if (!Grapple.Grappling)
    //    {
    //        KeyboardMovement();
    //        KeyboardJumping();
    //    }
    //
    //    if (Input.GetKey(KeyCode.Escape))
    //        Application.Quit(0);
    //}

    //void ControllerJumping()
    //{
    //    //jumping with the controller's A button
    //    if (XInput.GetKeyPressed(0, (int)JumpButton))
    //        Jump();
    //}

    //void KeyboardJumping()
    //{
    //    //jumping using Space
    //    if (Input.GetKeyDown(KeyCode.Space))
    //        Jump();
    //}

    //void JumpLogic()
    //{
    //    if (rb.velocity.y >= -0.000000001 && rb.velocity.y <= 0.000000001)
    //    {
    //        canJump = true;
    //        Jumping = false;
    //        GetComponentInChildren<Wings>().StopGlide(rb);
    //    }
    //    else
    //        Jumping = true;
    //}

    //void Jump()
    //{
    //    if(canJump)
    //    {
    //        if (Jumping)
    //        {
    //            rb.AddForce(new Vector3(0.0f, secondJump, 0.0f), ForceMode.Force);
    //            canJump = false;
    //        }
    //        else
    //            rb.AddForce(new Vector3(0.0f, firstJump, 0.0f), ForceMode.Force);
    //    }
    //    else
    //    {
    //        //do nothing, I just like having else statements
    //    }
    //}

    void KeyboardMovement()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        Move(moveInput);
    }

    //void ControllerMovement()
    //{
    //    moveInput.x = XInput.GetLeftX();
    //    moveInput.y = XInput.GetLeftY();
    //
    //    Move(moveInput);
    //}

    void Move(Vector2 moving)
    {
        Vector3 playerControl = new Vector3(moving.x, 0.0f, moving.y);

        Camera moveCam = GetComponentInChildren<Camera>();

        Vector3 temp = moveCam.transform.forward;

        moveCam.transform.forward = Vector3.Normalize(new Vector3(temp.x, 0.0f, temp.z));

        transform.forward = moveCam.transform.forward;
        
        Vector3 forwards = moveCam.transform.TransformVector(playerControl) * speed * Time.fixedDeltaTime;
        forwards.y = 0;

        rb.velocity = forwards;
        Vector2 tempVel = HiddenMath.Clamp(new Vector2(rb.velocity.x, rb.velocity.z), 5f);

        rb.velocity = new Vector3(tempVel.x, rb.velocity.y, tempVel.y);

        moveCam.transform.forward = temp;
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    LayerMask mas = LayerMask.GetMask("Grapple Point");
    //    
    //    rb.velocity = new Vector3();
    //
    //    Grapple.Grappling = false;
    //    Jumping = false;
    //    canJump = true;
    //}
}