using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStickerBook : MonoBehaviour
{
    public GameObject Stickerbook;

    public GameObject CatOptionsButton;
    public GameObject RandomAssetsButton;
    public GameObject DogOptionsButton;
    public GameObject LowercaseLettersButton;
    public GameObject CapitalLettersButton;

    public GameObject CatOptions;
    public GameObject RandomOptions;
    public GameObject DogOptions;
    public GameObject LowercaseOptions;
    public GameObject CapitalOptions;

    public void WhenButtonClicked()
    {
        if (Stickerbook.activeInHierarchy == false)
        {
            Stickerbook.SetActive(true);

            CatOptionsButton.SetActive(true);
            RandomAssetsButton.SetActive(true);
            DogOptionsButton.SetActive(true);
            LowercaseLettersButton.SetActive(true);
            CapitalLettersButton.SetActive(true);

            CatOptions.SetActive(false);
            RandomOptions.SetActive(false);
            DogOptions.SetActive(false);
            LowercaseOptions.SetActive(false);
            CapitalOptions.SetActive(false);
        }
        else
        {
            Stickerbook.SetActive(false);

            CatOptions.SetActive(false);
            RandomOptions.SetActive(false);
            DogOptions.SetActive(false);
            LowercaseOptions.SetActive(false);
            CapitalOptions.SetActive(false);
        }
    }
   
}
