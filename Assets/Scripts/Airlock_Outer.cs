using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airlock_Outer : MonoBehaviour
{
    public GameObject DoorObject;
    public AudioSource audioS;
    public AudioClip Beep;
    public AudioClip Opening;
    public float xAxis = 1f;
    public float yAxis = 1f;
    public float zAxis = 1f;

    private bool Isopen = false;

    private void OnTriggerEnter(Collider Player)
    {
        if (Isopen == false)
        {
            DoorObject.transform.position += new Vector3(xAxis, yAxis, zAxis);
            audioS.PlayOneShot(Opening);
            audioS.PlayOneShot(Beep);
            Isopen = true;
            Invoke("IsOpening", .05f);
        }
    }

    private void OnTriggerExit(Collider Player)
    {
        if (Isopen == true)
        {
            DoorObject.transform.position -= new Vector3(xAxis, yAxis, zAxis);
            audioS.PlayOneShot(Opening);
            Isopen = false;
            Invoke("IsClosing", .1f);
        }
    }

    void IsOpening()
    {
        DoorObject.transform.position += new Vector3(xAxis, yAxis, zAxis);
    }

    void IsClosing()
    {
        DoorObject.transform.position -= new Vector3(xAxis, yAxis, zAxis);
    }
}
