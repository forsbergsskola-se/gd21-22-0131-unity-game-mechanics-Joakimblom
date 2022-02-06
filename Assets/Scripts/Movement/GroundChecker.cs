using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public float GroundCheckDistance = 0.6f;

    public float groundCheckSphereRadius = 0.5f;

    public bool isGrounded;



    // Update is called once per frame
    void Update()
    {
        CheckIfGrounded();
    }

    private void CheckIfGrounded()
    {
        //check if we're grounded, using a raycast
        //Vector3.down: down in world space.
        //-transform.up: down in the GameObject's local space.

        //var isGrounded = Physics.Raycast(transform.position, Vector3.down, GroundCheckDistance);
        
        var sphereCastRay = new Ray(transform.position, Vector3.down);
        isGrounded = Physics.SphereCast(sphereCastRay, groundCheckSphereRadius, GroundCheckDistance);


        //draw a ray in the editor, only for visualization.
        Debug.DrawRay(transform.position, Vector3.down * GroundCheckDistance, Color.cyan);
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position + Vector3.down * GroundCheckDistance,groundCheckSphereRadius);
    }
}
