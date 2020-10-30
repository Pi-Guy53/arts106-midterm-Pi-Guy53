using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{
    public int Health = 3;
    public Text EndScene;
    public Text HP;
    public GameObject FPS;
    public GameObject End_Camera;

    private void Start()
    {
        EndScene.text = "";
    }

    private void Update()
    {
        HP.text = "HP:" + Health;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Enemy_Bullet"))
        {
            Health = Health - 1;
            if (Health < 1)
            {
                EndScene.text = "Game Over!";
                End_Camera.SetActive(true);
                FPS.SetActive(false);
            }
        }
    }
}
