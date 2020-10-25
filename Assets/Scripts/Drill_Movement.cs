using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill_Movement : MonoBehaviour
{
    public GameObject Bottom;
    public GameObject Top;
    public GameObject Gears;
    bool Drill = true;

    private void Update()
    {
        float DisToBottom = Vector3.Distance(transform.position, Bottom.transform.position);
        float DisToTop = Vector3.Distance(transform.position, Top.transform.position);
        if (Drill == true)
        {
            transform.position += new Vector3(0, -.01f, 0);
            Gears.transform.Rotate(0, 0, -.25f);
        }

        if(Drill == false)
        {
            transform.position += new Vector3(0, .01f, 0);
            Gears.transform.Rotate(0, 0, .25f);
        }

        if (DisToBottom < 1)
        {
            Drill = false;
        }

        if (DisToTop < 1)
        {
            Drill = true;
        }
    }
}
