using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Weapons : MonoBehaviour
{
    public GameObject Weapon1;
    public GameObject Weapon2;
    public GameObject Weapon3;
    public GameObject Laser_Light;
    public GameObject Flash_Light;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Switch_weapon1();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Switch_weapon2();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Switch_weapon3();
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            if(Laser_Light.active)
            {
                Laser_Light.SetActive(false);
            }
            else
            {
                Laser_Light.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Flash_Light.active)
            {
                Flash_Light.SetActive(false);
            }
            else
            {
                Flash_Light.SetActive(true);
            }
        }
    }


    void Switch_weapon1()
    {
    Weapon1.SetActive(true);
    Weapon2.SetActive(false); 
    Weapon3.SetActive(false);
    }

    void Switch_weapon2()
    {
    Weapon1.SetActive(false);
    Weapon2.SetActive(true);
    Weapon3.SetActive(false);
    }

    void Switch_weapon3()
    {
    Weapon1.SetActive(false);
    Weapon2.SetActive(false);
    Weapon3.SetActive(true);
    }

}