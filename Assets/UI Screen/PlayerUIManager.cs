using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUIManager : MonoBehaviour
{
    public GameObject ExitScreen;
    public GameObject MainUIScreen;
    public GameObject Player;
    public GameObject NewCamera;
    private bool isHidden = true;

    private void Start()
    {
        ExitScreen.SetActive(false);
        NewCamera.SetActive(false);
        Player.SetActive(true);
        MainUIScreen.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isHidden == true)
            {
                ExitScreen.SetActive(true);
                isHidden = false;
                Player.SetActive(false);
                NewCamera.SetActive(true);
                MainUIScreen.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cancel();
            }
        }
    }

    public void Cancel()
    {
        ExitScreen.SetActive(false);
        isHidden = true;
        Player.SetActive(true);
        NewCamera.SetActive(false);
        MainUIScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}