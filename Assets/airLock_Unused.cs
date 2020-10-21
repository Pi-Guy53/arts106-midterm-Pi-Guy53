using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airLock_Unused : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject panel7;
    public GameObject panel8;

    private void OnTriggerEnter(Collider Player)
    {
        panel1.SetActive(false);
        Invoke("Panel2", .1f);
    }

    private void OnTriggerExit(Collider Player)
    {
        panel8.SetActive(true);
        Invoke("Panel7_close", .1f);
    }

    void Panel2()
    {
        panel2.SetActive(false);
        Invoke("Panel3", .1f);
    }

    void Panel3()
    {
        panel3.SetActive(false);
        Invoke("Panel4", .1f);
    }

    void Panel4()
    {
        panel4.SetActive(false);
        Invoke("Panel5", .1f);
    }

    void Panel5()
    {
        panel5.SetActive(false);
        Invoke("Panel6", .1f);
    }

    void Panel6()
    {
        panel6.SetActive(false);
        Invoke("Panel7", .1f);
    }

    void Panel7()
    {
        panel7.SetActive(false);
        Invoke("Panel8", .1f);
    }

    void Panel8()
    {
        panel8.SetActive(false);
    }

    void Panel7_close()
    {
        panel7.SetActive(true);
        Invoke("Panel6_close", .1f);
    }

    void Panel6_close()
    {
        panel6.SetActive(true);
        Invoke("Panel5_close", .1f);
    }

    void Panel5_close()
    {
        panel5.SetActive(true);
        Invoke("Panel4_close", .1f);
    }

    void Panel4_close()
    {
        panel4.SetActive(true);
        Invoke("Panel3_close", .1f);
    }

    void Panel3_close()
    {
        panel3.SetActive(true);
        Invoke("Panel2_close", .1f);
    }

    void Panel2_close()
    {
        panel2.SetActive(true);
        Invoke("Panel1_close", .1f);
    }

    void Panel1_close()
    {
        panel1.SetActive(true);
    }
}
