using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Single);
    }

    public void ThanksToButton()
    {
        SceneManager.LoadScene("ThanksTo", LoadSceneMode.Single);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
