using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAssetButton : MonoBehaviour
{
    public GameObject BrownDog;
    public GameObject ClayDawg;
    public GameObject ConDawg;
    public GameObject GabDawg;
    public GameObject GoldDawg;
    public GameObject HuskDawg;
    public GameObject JohnDawg;
    public GameObject LabDawg;
    public GameObject SpotDawg;

    public GameObject PurpleSpotsPaper;
    public GameObject PurpleStripesPaper;
    public GameObject PurpleFlowerPaper;
    public GameObject PurplePatternPaper;
    public GameObject LilacPaper;

    public GameObject CatOptionsButton;
    public GameObject RandomAssetsButton;
    public GameObject DogOptionsButton;

    public GameObject CatOptions;
    public GameObject RandomOptions;
    public GameObject DogOptions;

    public void DeactivateButtons()
    {
        PurpleSpotsPaper.SetActive(false);
        PurpleStripesPaper.SetActive(false);
        PurplePatternPaper.SetActive(false);
        PurpleFlowerPaper.SetActive(false);
        LilacPaper.SetActive(false);

        CatOptionsButton.SetActive(false);
        RandomAssetsButton.SetActive(false);
        DogOptionsButton.SetActive(false);

    }

    public void ActivateButtons()
    {
        BrownDog.SetActive(true);
        ClayDawg.SetActive(true);
        ConDawg.SetActive(true);
        GabDawg.SetActive(true);
        GoldDawg.SetActive(true);
        HuskDawg.SetActive(true);
        JohnDawg.SetActive(true);
        LabDawg.SetActive(true);
        SpotDawg.SetActive(true);

        DogOptions.SetActive(true);

    }

    public void CatButton()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
