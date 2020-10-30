using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public AudioClip Hit;
    public AudioSource audioS;
    public float Grenade_Life = 2.0f;
    public GameObject shrapnel;
    public Transform shootFrom;
    public GameObject xplode_Light;

    void Update()
    {
        Invoke("Explode", Grenade_Life);
    }

    void Explode()
    {
        GameObject thisBullet = Instantiate(shrapnel, gameObject.transform.position, gameObject.transform.rotation);
        thisBullet.GetComponent<Rigidbody>().AddForce(shootFrom.forward * 40f, ForceMode.Impulse);

        GameObject thisBullet1 = Instantiate(shrapnel, gameObject.transform.position, gameObject.transform.rotation);
        thisBullet1.GetComponent<Rigidbody>().AddForce(shootFrom.right * 40f, ForceMode.Impulse);

        GameObject thisBullet2 = Instantiate(shrapnel, gameObject.transform.position, gameObject.transform.rotation);
        thisBullet2.GetComponent<Rigidbody>().AddForce(shootFrom.up * 40f, ForceMode.Impulse);

        GameObject thisBullet3 = Instantiate(shrapnel, gameObject.transform.position, gameObject.transform.rotation);
        thisBullet3.GetComponent<Rigidbody>().AddForce(shootFrom.forward * -40f, ForceMode.Impulse);

        GameObject thisBullet4 = Instantiate(shrapnel, gameObject.transform.position, gameObject.transform.rotation);
        thisBullet4.GetComponent<Rigidbody>().AddForce(shootFrom.right * -40f, ForceMode.Impulse);

        GameObject thisBullet5 = Instantiate(shrapnel, gameObject.transform.position, gameObject.transform.rotation);
        thisBullet5.GetComponent<Rigidbody>().AddForce(shootFrom.up * -40f, ForceMode.Impulse);

        xplode_Light.SetActive(true);
        Object.Destroy(gameObject, 0.3f);
        AudioSource.PlayClipAtPoint(Hit, transform.position);
    }
}