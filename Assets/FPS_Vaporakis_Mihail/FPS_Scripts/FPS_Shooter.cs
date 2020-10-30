using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS_Shooter : MonoBehaviour
{
    public AudioClip ReloadSound;
    public AudioClip FireSound;
    public AudioSource audioS;
    public GameObject SwitchWeapon;
    public string Name;
    public float shootForce = 10f;
    public float RateOfFire = 0.15f;
    public GameObject bullet;
    public Transform shootFrom;
    public GameObject flash;
    public GameObject barrel;
    public float ScopeZoom = 120f;
    public GameObject ScopeCrossHairs;
    public Camera Cam;
    public int ammo = 32;
    public bool Automatic = false;
    int Original_ammo = 1;
    public Text AmmoCount;
    public Text WeaponName;
    string AmmoCountMsg;
    private bool CoolDown = false;

    private void Start()
    {
        Original_ammo = ammo;
        AmmoCountMsg = "Press R to Reload";
        }

    void Update()
    {
        WeaponName.text = Name;

        if (ammo > 0)
        {
            AmmoCount.text = "Ammo: " + ammo;
        }
        else
        {
            AmmoCount.text = AmmoCountMsg;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ammo < 1)
            {
                audioS.PlayOneShot(ReloadSound);
                AmmoCountMsg = "Reloading";
                SwitchWeapon.SetActive(false);
                Invoke("Reload", 2.5f);
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (ammo > 0)
            {
                ShootProjectile();
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Cam.fieldOfView = ScopeZoom;
            ScopeCrossHairs.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Cam.fieldOfView = 60f;
            ScopeCrossHairs.SetActive(false);
        }
    }

    void ShootProjectile()
    {
        if (CoolDown == false)
        {
            GameObject thisBullet = Instantiate(bullet, shootFrom.transform.position, shootFrom.transform.rotation);
            thisBullet.GetComponent<Rigidbody>().AddForce(shootFrom.forward * shootForce, ForceMode.Impulse);
            audioS.PlayOneShot(FireSound);
            Muzzel_Flash();
            ammo--;
            CoolDown = true;
        }
    }

    void Muzzel_Flash()
    {
        flash.SetActive(true);
        barrel.transform.Rotate(-5, 0, 0);
        Invoke("Auto", RateOfFire);
        Invoke("Muzzel_Flash_Off", 0.1f);
    }
    
    void Muzzel_Flash_Off()
    {
        flash.SetActive(false);
        barrel.transform.Rotate(5, 0, 0);
    }

    void Auto()
    {
        CoolDown = false;
        if (Automatic == true)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (ammo > 0)
                {
                    ShootProjectile();
                }
            }
        }
    }

    void Reload()
    {
        ammo = Original_ammo;
        AmmoCountMsg = "Press R to Reload";
        SwitchWeapon.SetActive(true);
    }

}