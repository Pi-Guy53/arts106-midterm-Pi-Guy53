using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedGun : MonoBehaviour
{
    private bool CoolDown = false;
    public bool Attack = true;
    public Transform Fire1;
    public GameObject Shell;
    public float RateOfFire = 1f;
    private float ShootForce = 50f;
    public AudioSource AudioS;
    public AudioClip FireSound;

    void Update()
    {
        if (Attack == true)
        {
            if (CoolDown == false)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject thisBullet = Instantiate(Shell, Fire1.transform.position, Fire1.transform.rotation);
        thisBullet.GetComponent<Rigidbody>().AddForce(Fire1.transform.forward * ShootForce, ForceMode.Impulse);

        AudioS.PlayOneShot(FireSound);
        CoolDown = true;
        Invoke("Reload", RateOfFire);
    }

    void Reload()
    {
        CoolDown = false;
    }
}