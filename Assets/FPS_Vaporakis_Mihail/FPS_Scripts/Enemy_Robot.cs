using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Robot : MonoBehaviour
{
    public GameObject Cannon1;
    public GameObject Cannon2;
    public Transform Target;
    public GameObject Body;
    public float Speed = 2;
    //private Vector3 TargetPos;

    private void Update()
    {
        Body.transform.LookAt(Target);
        transform.position += transform.forward * Speed * Time.deltaTime;
        Cannon1.transform.LookAt(Target);
        Cannon2.transform.LookAt(Target);

    }
}
