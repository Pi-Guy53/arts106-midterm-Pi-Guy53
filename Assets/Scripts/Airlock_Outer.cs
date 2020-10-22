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

    private void OnTriggerEnter(Collider Player)
    {
        DoorObject.transform.position += new Vector3(xAxis, yAxis, zAxis);
        audioS.PlayOneShot(Opening);
        audioS.PlayOneShot(Beep);
    }

    private void OnTriggerExit(Collider Player)
    {
        DoorObject.transform.position -= new Vector3(xAxis, yAxis, zAxis);
        audioS.PlayOneShot(Opening);
    }
}
