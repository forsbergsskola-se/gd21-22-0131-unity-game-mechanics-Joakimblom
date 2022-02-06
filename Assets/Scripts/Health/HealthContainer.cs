
using System;
using UnityEngine;

public class HealthContainer : MonoBehaviour
{
   [SerializeField] private float maxHealth = 3f;
   
   private float currentHealth;

   private void Start()
   {
      currentHealth = maxHealth;
   }

  /* private void OnEnable()
   {
      //this method runs when a gameObject is active
   }

   private void OnDisable()
   {
      //this method runs when a gameObject is not active
   }
   */

   public void DealDamage(float damage)
   {
      currentHealth -= damage;
   }

   public void instantKill()
   {
      Die(); //You could also make Die() public and call that directly.
   }
   private void checkHealth()
   {
      if (currentHealth <= 0)
      {
         Die();
      }
   }

   private void Die()
   {
      Destroy(gameObject);
      // gameObject.SetActive(false);  - this disables the gameObject
   }

}
