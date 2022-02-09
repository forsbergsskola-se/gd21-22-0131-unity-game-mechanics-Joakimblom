using UnityEngine;

public class GunController : MonoBehaviour 
{
    public Rigidbody smallBullet;
    [SerializeField] double upwardsbulletforce = 0.5f;
    [SerializeField] float bulletSpeed = 25f;
    
    void Update () 
    {
        
        if (Input.GetButtonUp("Fire1"))
        {
            NormalFire();
        }
        
    }

    private void NormalFire()
    {
        Rigidbody projectile = Instantiate(smallBullet, transform.position, transform.rotation);
        projectile.velocity = transform.TransformDirection(new Vector3(bulletSpeed, (float) upwardsbulletforce, 0));
        Destroy(projectile.gameObject, 3.5f);
    }
}
