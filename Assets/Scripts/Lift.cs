using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bottom;
    public GameObject Top;
    public int LiftSpeed = 0;

    void Update()
    {
        float PlayerDis = Vector3.Distance(transform.position, Player.transform.position);
        float Up = Vector3.Distance(transform.position, Top.transform.position);
        float Down = Vector3.Distance(transform.position, Bottom.transform.position);

        transform.position += new Vector3(0, LiftSpeed, 0) * Time.deltaTime *2;

        if (Up < 0.1f)
        {
            LiftSpeed = 0;
        }

        if (Down < 0.1f)
        {
            LiftSpeed = 0;
        }

        if (PlayerDis < 2)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                if(Up < 0.3f)
                {
                    transform.position += new Vector3(0, -.2f, 0);
                    LiftSpeed = -1;
                }

                if(Down < 0.3f)
                {
                    transform.position += new Vector3(0, .2f, 0);
                    LiftSpeed = 1;
                }
            }
        }
    }
}
