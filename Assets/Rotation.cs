using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float xAxis = 0f;
    public float yAxis = 0f;
    public float zAxis = 0f;

    void Update()
    {
        transform.Rotate(xAxis, yAxis, zAxis);
    }
}
