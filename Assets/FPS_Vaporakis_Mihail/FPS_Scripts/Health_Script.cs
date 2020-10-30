using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Script : MonoBehaviour
{
    public int Health = 3;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Bullet"))
        {
            Health = Health - 1;
            if (Health < 1)
            {
                Destroy(gameObject, 0.1f);
            }
        }
    if(other.collider.CompareTag("Enemy_Bullet"))
        {
            Health = Health - 1;
            if (Health < 1)
            {
                Destroy(gameObject, 0.1f);
            }
        }

    }
}
