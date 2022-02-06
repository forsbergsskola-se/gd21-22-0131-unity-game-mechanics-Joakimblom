using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    public Rigidbody myRigidBody;

    public PlayerInputController playerInputController;
    
    public GroundChecker MyGroundChecker;
    
    public float minimumJumpForce = 100f;
    
    public float maximumJumpForce = 1000f;

    public float JumpChargeTime = 1f;

    private float ChargeProgress;
    
    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
       
        //if we are holding the jump button: Charge a jump.
        if (playerInputController.jumpInput == true)
        {
            //increase charge progress, dividing Time.DeltaTime by JumpChargeTime let's us control how many second it takes to charge at full jump.
            ChargeProgress += Time.deltaTime / JumpChargeTime;
           // ChargeProgress = ChargeProgress + Time.deltaTime / JumpChargeTime; This does the same as using +=
        }
        
        
        //if (jumpInput && isGrounded) this works the same way.
        if (playerInputController.jumpInputUp == true)
        {
            //calculate jumpForce before restting chargeProgress
            //Linear interpolation (Lerp) between minimumJumpForce and maximumJumpForce. ChargeProgress controls where in-between the two values we are.
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, ChargeProgress);
            //remember to reset jumpForce
            ChargeProgress = 0f;
            
            //if we are grounded: Jump
            if (MyGroundChecker.isGrounded==true)
            {
                myRigidBody.AddForce(0, jumpForce, 0);
            }
        }
    }
}
