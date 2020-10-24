using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill_Movement : MonoBehaviour
{
    public GameObject Bottom;

    private void Update()
    {
        float DisToBottom = Vector3.Distance(transform.position, Bottom.transform.position);
        transform.position += new Vector3(0, -.005f, 0);

        if(DisToBottom < 1)
        {
            transform.position += new Vector3(0, .005f, 0);
        }
    }
}
