using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public AudioClip Hit;
    //public AudioSource audioS;
    public float Bullet_Life = 2.0f;
    public float Damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        //AudioSource.PlayClipAtPoint(Hit, transform.position);
        Destroy(gameObject);
    }
    void Update()
    {
        Object.Destroy(gameObject, Bullet_Life);
    }

}