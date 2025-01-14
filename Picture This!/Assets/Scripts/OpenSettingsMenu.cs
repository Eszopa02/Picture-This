using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettingsMenu : MonoBehaviour
{
    public GameObject SettingsMenu;
    public GameObject MainMenu;

    public void whenButtonClicked()
    {
        if (SettingsMenu.activeInHierarchy == true)
        {
            SettingsMenu.SetActive(false);
            MainMenu.SetActive(true);
        }
        else
        {
            SettingsMenu.SetActive(true);
            MainMenu.SetActive(false);
        }
           
    }
}
