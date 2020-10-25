using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunerBuggy : MonoBehaviour
{
    [SerializeField]
    private GameObject Vehicle;

    public float Speed = 25f;
    public float Turn = 3f;

    private void Update()
    {

        if (Input.GetKey(name: "w"))
        {
            Vehicle.transform.position += transform.forward * Time.deltaTime * Speed;
        }

        if (Input.GetKey(name: "s"))
        {
            Vehicle.transform.position -= transform.forward * Time.deltaTime * Speed / 2;
        }

        if (Input.GetKey(name: "a"))
        {
            Vehicle.transform.Rotate(0, -Turn, 0);
        }

        if (Input.GetKey(name: "d"))
        {
            Vehicle.transform.Rotate(0, Turn, 0);
        }

        Vehicle.transform.position -= transform.up * Time.deltaTime * 2;

    }

}