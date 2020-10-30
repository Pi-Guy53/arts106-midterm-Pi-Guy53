using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Pan : MonoBehaviour
{
    public GameObject FPS;
    public GameObject PanCamera;
    public GameObject Canvas;
    private bool Panned = false;


    private void Start()
    {
    PanCamera.SetActive(false);
    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Panned == false)
        {
            FPS.SetActive(false);
            PanCamera.SetActive(true);
            Canvas.SetActive(false);
            Invoke("EndAnim", 3.5f);
            Panned = true;
        }
    }

    void EndAnim()
    {
        FPS.SetActive(true);
        PanCamera.SetActive(false);
        Canvas.SetActive(true);
    }
}
