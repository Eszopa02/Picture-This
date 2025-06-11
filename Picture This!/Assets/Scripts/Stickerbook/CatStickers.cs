using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStickers : MonoBehaviour
{
    public GameObject JJHead;
    public GameObject MartiniHead;
    public GameObject SiameseHead;
    public GameObject TabbyHead;
    public GameObject VoidHead;
    public GameObject WhiteCat;

    public GameObject CatOptionsButton;
    public GameObject RandomAssetsButton;
    public GameObject DogOptionsButton;
    public GameObject LowercaseLettersButton;
    public GameObject CapitalLettersButton;


    public void DeactivateButtons()
    {
        CatOptionsButton.SetActive(false);
        RandomAssetsButton.SetActive(false);
        DogOptionsButton.SetActive(false);
        LowercaseLettersButton.SetActive(false);
        CapitalLettersButton.SetActive(false);

    }

    public void ActivateButtons()
    {
        JJHead.SetActive(true);
        MartiniHead.SetActive(true);
        SiameseHead.SetActive(true);
        TabbyHead.SetActive(true);
        VoidHead.SetActive(true);
        WhiteCat.SetActive(true);

    }

    

    public void CatButton()
    {
        DeactivateButtons();

        ActivateButtons();
    }

   
}
