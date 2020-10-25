using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Audio : MonoBehaviour
{
    public GameObject BackgroundTrigger;
    public GameObject BackgroundCaveTrigger;
    public GameObject OutsideTrigger;
    public GameObject InsideTrigger;

    public GameObject BackgroundMusic;
    public GameObject BackgroundCaveMusic;
    public GameObject OutsideAmbience;
    public GameObject InsideAmbience;

    private void Update()
    {
        float Background = Vector3.Distance(transform.position, BackgroundTrigger.transform.position);
        float Cave = Vector3.Distance(transform.position, BackgroundCaveTrigger.transform.position);
        float Outside = Vector3.Distance(transform.position, OutsideTrigger.transform.position);
        float Inside = Vector3.Distance(transform.position, InsideTrigger.transform.position);

        //Background Music
        if(Background < 1)
        {
            BackgroundCaveMusic.SetActive(false);
            BackgroundMusic.SetActive(true);
        }

        if (Cave < 1)
        {
            BackgroundCaveMusic.SetActive(true);
            BackgroundMusic.SetActive(false);
        }

        //Ambient Sounds
        if (Outside < 1)
        {
            InsideAmbience.SetActive(false);
            OutsideAmbience.SetActive(true);
        }

        if (Inside < 1)
        {
            InsideAmbience.SetActive(true);
            OutsideAmbience.SetActive(false);
        }

    }
}
