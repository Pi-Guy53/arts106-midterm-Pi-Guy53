using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shooter : MonoBehaviour
{
    public GameObject Cannon1;
    public GameObject Cannon2;
    public GameObject Cannon1_Fire_Transform;
    public GameObject Cannon2_Fire_Transform;
    public GameObject Grenade_Transfrom;
    public GameObject bullet;
    public GameObject grenade;
    public GameObject BulletCasing;
    public AudioSource audioS;
    public AudioClip FireSound;
    public GameObject Flash1;
    public GameObject Flash2;
    public GameObject target;
    public float Grenade_Chance = 30f;
    public float Range = 50f;
    public float RateOfFire = 0.5f;
    public float GrenadeForce = 25f;
    int Ammo = 1;


    void Update()
    {
        float Distance = Vector3.Distance(transform.position, target.transform.position);
        GrenadeForce = Vector3.Distance(transform.position, target.transform.position);

        if (Distance < Range)
        {
            Attack();
            Cannon1.transform.Rotate(0, -.5f / RateOfFire * 5, 0);
            Cannon2.transform.Rotate(0, .5f / RateOfFire * 5, 0);
        }
    }

    private void OnTriggerEnter(Collider Bullet)
    {
        Range = Vector3.Distance(transform.position, target.transform.position) + Range;
    }

    void AttackGrenade()
    {
        GameObject thisGrenade = Instantiate(grenade, Grenade_Transfrom.transform.position, Grenade_Transfrom.transform.rotation);
        thisGrenade.GetComponent<Rigidbody>().AddForce(Grenade_Transfrom.transform.forward * GrenadeForce/2, ForceMode.Impulse);
    }

    void Attack()
    {
        if (Ammo > 0)
        {
            GameObject thisBullet = Instantiate(bullet, Cannon1_Fire_Transform.transform.position, Cannon1.transform.rotation);
            thisBullet.GetComponent<Rigidbody>().AddForce(Cannon1_Fire_Transform.transform.forward * 120, ForceMode.Impulse);
            GameObject thisBulletCasing = Instantiate(BulletCasing, Cannon1.transform.position, Cannon1.transform.rotation);
            audioS.PlayOneShot(FireSound);
            Ammo = 0;
            Flash1.SetActive(true);
            Invoke("MuzzleFlash", .1f);
            Invoke("Attack2", RateOfFire);
        }
    }

    void Attack2()
    {
        GameObject thisBullet1 = Instantiate(bullet, Cannon2_Fire_Transform.transform.position, Cannon2.transform.rotation);
        thisBullet1.GetComponent<Rigidbody>().AddForce(Cannon2_Fire_Transform.transform.forward * 120, ForceMode.Impulse);
        GameObject thisBulletCasing = Instantiate(BulletCasing, Cannon2.transform.position, Cannon2.transform.rotation);
        audioS.PlayOneShot(FireSound);
        Ammo = 0;
        Flash2.SetActive(true);
        Invoke("MuzzleFlash2", .1f);
        Invoke("Reload", RateOfFire);
    }

    void MuzzleFlash()
    {
        Flash1.SetActive(false);
    }

    void MuzzleFlash2()
    {
        Flash2.SetActive(false);
    }

    void Reload()
    {
        Ammo = 1;
        int grenadeChance = Random.Range(0, 100);

        if (grenadeChance < Grenade_Chance)
        {
        AttackGrenade();
        }
    }
}
