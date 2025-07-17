using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject Game;

    public void OpenMainMenu()
    {
        MainMenu.SetActive(true);
        Settings.SetActive(false);
        Game.SetActive(false);
    }

    public void OpenSettings()
    {
        MainMenu.SetActive(false);
        Settings.SetActive(true);
        Game.SetActive(false);
    }

    public void OpenGame()
    {
        MainMenu.SetActive(false);
        Settings.SetActive(false);
        Game.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
