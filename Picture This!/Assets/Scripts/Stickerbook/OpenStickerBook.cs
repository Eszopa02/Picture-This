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

            
        }
        else 
        {
            Stickerbook.SetActive(true);

            
        }
        
    }
   
}
