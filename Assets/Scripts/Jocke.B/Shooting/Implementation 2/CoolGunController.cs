using UnityEngine;

public class CoolGunController : MonoBehaviour 
{
    public Rigidbody bigbullet;
    [SerializeField] double upwardsbulletforce = 0.5f;
    [SerializeField] float bulletSpeed = 25f;
    [SerializeField] private float chargeUpTimeScale = 1;
    [SerializeField] private PlayerWalkController playerWalkController;
    [SerializeField] private PlayerImmediateJumpController playerImmediateJumpController;
    float chargeupTime;
    Vector3 bulletScale = new Vector3(0.1f,0.1f,0.1f);
    
    void Update () 
    {
        if (Input.GetButtonDown("Fire2"))
        {
            BeginChargeAttack();
        }
        if (Input.GetButton("Fire2"))
        {
            ChargeScaling();
        }
        if (Input.GetButtonUp("Fire2"))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        
        playerImmediateJumpController.enabled = true;
        playerWalkController.enabled = true;

        Debug.Log("I get BIG bullet!");
        Rigidbody projectile = Instantiate(bigbullet, transform.position, transform.rotation);
        projectile.velocity = transform.TransformDirection(new Vector3(bulletSpeed, (float) upwardsbulletforce, 0));
        projectile.transform.localScale = bulletScale;
        bulletScale = Vector3.zero;
        chargeupTime = 0;
        Destroy(projectile.gameObject, 0.7f);
    }

    private void ChargeScaling()
    {
        chargeupTime += Time.deltaTime * chargeUpTimeScale;
        bulletScale = Vector3.Lerp(bulletScale, new Vector3(4, 4, 4), chargeupTime);
    }

    private void BeginChargeAttack()
    {
        playerImmediateJumpController.enabled = false;
        playerWalkController.enabled = false;
    }
}
