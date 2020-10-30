using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Casing : MonoBehaviour
{
    void Start()
    {
        Object.Destroy(gameObject, 5f);
    }

}
