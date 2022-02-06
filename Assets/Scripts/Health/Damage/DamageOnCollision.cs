using UnityEditor;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
  [SerializeField] private float damage = 1f;

  //Called only the one framne that two collider/rigidbodies start being in contact.
/*  private void OnCollisionEnter(Collision other)
  {
    //"other" contains data about our collision.
    //get the GameObject that we collided with.
    var collidedGameObject = other.gameObject;
    
    //look for a healthContainer on the gameObject we collided with, using GetComponent.
    var healthContainerOnCollidedGameObject = collidedGameObject.GetComponent<HealthContainer>();
    //Make sure that a HealthContainter component was found before dealing damage.
    if (healthContainerOnCollidedGameObject != null) 
    {
      healthContainerOnCollidedGameObject.DealDamage(damage);
      //healthContainerOnCollidedGameObject.instantKill();
    }
  }
  */
  //example of damage over time in continuous collision.
   //Called every frame that two collider/rigidbodies are in contact.
  private void OnCollisionStay(Collision other)
  {
   //"other" contains data about our collision.
   //get the GameObject that we collided with.
   var collidedGameObject = other.gameObject;
   
   //Look for HealthContainer on the GameObject we collided with, using GetComponent.
   var healthContainerOnCollideGameObject = collidedGameObject.GetComponent<HealthContainer>();

   if (healthContainerOnCollideGameObject != null)
   {
       healthContainerOnCollideGameObject.DealDamage(damage * Time.deltaTime); // deal damage over time
   }
   
  }
}
