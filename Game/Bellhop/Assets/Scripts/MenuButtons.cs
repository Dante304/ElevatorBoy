using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PressStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void PressOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void PressExit()
    {
        Application.Quit();
    }
}
