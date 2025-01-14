using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public void MenuButton()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);

    }

    public void PlayButton()
    {
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
    }
    
    public void SettingsButton()
    {
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
