using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject DoorObject;
    public float xAxis = 0f;
    public float yAxis = 0f;
    public float zAxis = 0f;

    private void OnTriggerEnter(Collider Player)
    {
        DoorObject.transform.position += new Vector3(xAxis, yAxis, zAxis);
    }

    private void OnTriggerExit(Collider Player)
    {
        DoorObject.transform.position -= new Vector3(xAxis, yAxis, zAxis);
    }
}
