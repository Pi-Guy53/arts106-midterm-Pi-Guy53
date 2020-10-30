using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject DoorObject;
    public float xAxis = 0f;
    public float yAxis = 0f;
    public float zAxis = 0f;
    private bool IsOpen = false;

    private void OnTriggerEnter(Collider Player)
    {
        if (IsOpen == false)
        {
            DoorObject.transform.position += new Vector3(xAxis, yAxis, zAxis);
            Invoke("Open", .1f);
            IsOpen = true;
        }
    }

    private void OnTriggerExit(Collider Player)
    {
        if (IsOpen == true)
        {
            DoorObject.transform.position -= new Vector3(xAxis, yAxis, zAxis);
            Invoke("Close", .1f);
            IsOpen = false;
        }
    }

    void Open()
    {
        DoorObject.transform.position += new Vector3(xAxis, yAxis, zAxis);
    }

    void Close()
    {
        DoorObject.transform.position -= new Vector3(xAxis, yAxis, zAxis);
    }
}
