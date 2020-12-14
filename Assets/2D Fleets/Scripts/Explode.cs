using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject Explosion;
    public bool IsExploding = false;

    void Update()
    {
        if (IsExploding == true)
        {
            GameObject thisblast = Instantiate(Explosion, transform.position, transform.rotation);
            Object.Destroy(gameObject, .001f);
        }
    }
}
