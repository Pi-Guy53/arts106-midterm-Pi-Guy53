using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour
{
    public float LiftTime = 0;
    public int Damage = 1;

    void Start()
    {
        Object.Destroy(gameObject, LiftTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shell"))
        { }
        else
        {
            Object.Destroy(gameObject, .001f);
        }
    }
}
