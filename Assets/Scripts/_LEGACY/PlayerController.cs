using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    
    public float movespeed = 5f;
    public float jumpForce = 500f;
    public float GroundCheckDistance = 1f;

    public float groundCheckSphereRadius = 0.5f;
    // Update is called once per frame
    void Update()
    {
        //we will seperate scripts for these mechanics, but here's an example of putting the code in different methods.
        HandleMovement();
        HandleJump();
    }

    private void HandleJump()
    {
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        //check if we're grounded, using a raycast
        //Vector3.down: down in world space.
        //-transform.up: down in the GameObject's local space.

        //var isGrounded = Physics.Raycast(transform.position, Vector3.down, GroundCheckDistance);

        var sphereCastRay = new Ray(transform.position, Vector3.down);
        var isGrounded = Physics.SphereCast(sphereCastRay, groundCheckSphereRadius, GroundCheckDistance);


        //draw a ray in the editor, only for visualization.
        Debug.DrawRay(transform.position, Vector3.down * GroundCheckDistance, Color.cyan);

        //if (jumpInput && isGrounded) this works the same way.
        if (jumpInput == true && isGrounded == true)
        {
            myRigidBody.AddForce(0, jumpForce, 0);
        }
    }

    private void HandleMovement()
    {
         
        var moveInput = Input.GetAxis("Horizontal");
        
        //Debug.Log("Our move input:" + moveInput);
        
        //Gets the rigidbody and adds movement to the
        myRigidBody.velocity = new Vector3(x: moveInput * movespeed, myRigidBody.velocity.y, z: 0);
        
        
    }




}
