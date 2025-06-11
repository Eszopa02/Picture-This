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
        if (Stickerbook.activeInHierarchy == true)
        {
            Stickerbook.SetActive(false);

            CatOptionsButton.SetActive(false);
            RandomAssetsButton.SetActive(false);
            DogOptionsButton.SetActive(false);
            LowercaseLettersButton.SetActive(false);
            CapitalLettersButton.SetActive(false);

            CatOptions.SetActive(false);
            RandomOptions.SetActive(false);
            DogOptions.SetActive(false);
            LowercaseOptions.SetActive(false);
            CapitalOptions.SetActive(false);
        }
        else 
        {
            Stickerbook.SetActive(true);

             CatOptionsButton.SetActive(true);
             RandomAssetsButton.SetActive(true);
             DogOptionsButton.SetActive(true);
             LowercaseLettersButton.SetActive(true);
             CapitalLettersButton.SetActive(true);

            /*  CatOptions.SetActive(true);
              RandomOptions.SetActive(true);
              DogOptions.SetActive(true);
              LowercaseOptions.SetActive(true);
              CapitalOptions.SetActive(true); */

            CatOptions.SetActive(true);
            RandomOptions.SetActive(true);
            DogOptions.SetActive(true);
            LowercaseOptions.SetActive(true);
            CapitalOptions.SetActive(true);
        }
        
    }
   
}
