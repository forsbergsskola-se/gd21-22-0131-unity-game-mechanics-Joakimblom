using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    public Rigidbody myRigidBody;

    public float jumpForce = 1000f;
    
    public GroundChecker MyGroundChecker;

    public PlayerInputController playerInputController;
    
    

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        
        
        //if (jumpInput && isGrounded) this works the same way.
        if (playerInputController.jumpInputDown == true && MyGroundChecker.isGrounded == true)
        {
            
            myRigidBody.AddForce(0, jumpForce, 0);
        }
    }
}