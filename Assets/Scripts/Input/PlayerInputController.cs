
using System;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
   public float walkInput;
   public bool jumpInput;
   public bool jumpInputDown;
   public bool jumpInputUp;
   private void Update()
   {
      GetInput();
      
   }

   private void GetInput()
   {
      //get walk input.
      walkInput = Input.GetAxis("Horizontal");
      //get jumpInput
      jumpInputDown = Input.GetKeyDown(KeyCode.Space);
      jumpInput = Input.GetKey(KeyCode.Space);
      jumpInputUp = Input.GetKeyUp(KeyCode.Space);

   }
}
