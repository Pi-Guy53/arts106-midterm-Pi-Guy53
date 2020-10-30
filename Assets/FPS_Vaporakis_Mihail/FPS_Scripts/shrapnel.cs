using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrapnel : MonoBehaviour
{
    void Update()
    {
        Object.Destroy(gameObject, 2f);
    }

}
