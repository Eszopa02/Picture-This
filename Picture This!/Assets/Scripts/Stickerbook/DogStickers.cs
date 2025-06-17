using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogStickers : MonoBehaviour
{
    public GameObject BrownDog;
    public GameObject CleyDawg;
    public GameObject ConDawg;
    public GameObject GabDawg;
    public GameObject GoldDawg;
    public GameObject HuskDawg;
    public GameObject JohnDawg;
    public GameObject LabDawg;
    public GameObject SpotDawg;


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
        BrownDog.SetActive(true);
        CleyDawg.SetActive(true);
        ConDawg.SetActive(true);
        GabDawg.SetActive(true);
        GoldDawg.SetActive(true);
        HuskDawg.SetActive(true);
        JohnDawg.SetActive(true);
        LabDawg.SetActive(true);
        SpotDawg.SetActive(true);

    }

    public void DogButton()
    {
        
        DeactivateButtons();

        ActivateButtons();
    }
}
