
using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public PlayerInputController playerInputController;
    public float walkSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        HandleWalking();
    }
    
    private void HandleWalking()
    {
        //Apply moveSpeed to rigidbody.
        myRigidBody.velocity = new Vector3(x: playerInputController.walkInput * walkSpeed, myRigidBody.velocity.y, z: 0);
        
    }
    
}
