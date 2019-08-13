using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public bool EscButton;
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

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && EscButton)
        {
            SceneManager.LoadScene("Game");
        }

        
    }
}
