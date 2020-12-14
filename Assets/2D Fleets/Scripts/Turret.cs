using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private GameObject[] enemies;
    private int enemyCount;
    private float distance = 100f;
    private GameObject target;
    private Transform Targeter;
    public string EnemyFaction;

    public Transform Fire1;
    public GameObject Shell;
    public float RateOfFire = 1f;
    private float ShootForce = 50f;
    public int damage = 1;
    public float Range = 50f;
    public AudioSource AudioS;
    public AudioClip FireSound;
    private bool CoolDown = false;
    public bool Attack = true;
    public LaserBullet bulletRange;
    private float fireRate;

    void Update()
    {
        fireRate = Random.Range(RateOfFire / 1.5f, RateOfFire * 1.5f);
        enemies = GameObject.FindGameObjectsWithTag(EnemyFaction);

        for (int i = 0; i < enemies.Length; i++)
        {
            if (Vector3.Distance(gameObject.transform.position, enemies[i].transform.position) < distance)
            {
                distance = Vector3.Distance(gameObject.transform.position, enemies[i].transform.position);
                target = enemies[i];
                Targeter = target.transform;
            }

            if (Vector3.Distance(gameObject.transform.position, enemies[i].transform.position) > distance)
            {
                distance = Vector3.Distance(gameObject.transform.position, enemies[i].transform.position);
            }
        }

        if (distance < Range)
        {
            Attack = true;
        }

        if(distance > Range)
        {
            Attack = false;
        }

        if (Attack == true)
        {
            transform.LookAt(Targeter);
            float RandomX = Random.Range(-1, 1);
            float RandomY = Random.Range(-1, 1);
            float RandomZ = Random.Range(-1, 1);
            transform.Rotate(RandomX, RandomY, RandomZ);

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

        bulletRange.LiftTime = Range / ShootForce;

        AudioS.PlayOneShot(FireSound);
        CoolDown = true;
        Invoke("Recharge", fireRate);
    }

    void Recharge()
    {
        CoolDown = false;
    }
}