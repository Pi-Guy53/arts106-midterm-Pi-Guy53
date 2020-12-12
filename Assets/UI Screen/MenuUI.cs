using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public string MainScene;
    public string SecondaryScene;
    public string MenuScene;

    public void StartGame()
    {
        SceneManager.LoadScene(MainScene);
    }

    public void OpenSecondaryScene()
    {
        SceneManager.LoadScene(SecondaryScene);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(MenuScene);
    }
}