using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Quaternion;
using Debug = System.Diagnostics.Debug;

public class PlayerWalkController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public PlayerInputController playerInputController;
    public float walkSpeed = 5f;
    public Transform myTransform;
    
    // Update is called once per frame
    void Update()
    {
        HandleWalking();
    }
    private void HandleWalking()
    {
        myRigidBody.velocity = new Vector3(x: playerInputController.walkInput * walkSpeed, myRigidBody.velocity.y, z: 0);
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            myTransform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myTransform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}