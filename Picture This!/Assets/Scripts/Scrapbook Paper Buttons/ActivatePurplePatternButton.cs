using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePurplePatternButtons : MonoBehaviour
{
    public GameObject PurpleSpotsPaper;
    public GameObject PurpleStripesPaper;
    public GameObject PurplePatternPaper;
    public GameObject PurpleFlowerPaper;
    public GameObject LilacPaper;

    public GameObject BluePatternPaper;
    public GameObject GreenPatternPaper;
    public GameObject PurplePatternPaperTwo;
    public GameObject RedPatternPaper;
    public GameObject OrangePatternPaper;
    public GameObject YellowPatternPaper;

    public GameObject ColorfulPaperBlue;
    public GameObject ColorfulPaperPink;

    public GameObject FlowerOptions;
    public GameObject PatternOptions;
    public GameObject SpotsOptions;
    public GameObject StripesOptions;

    public GameObject CatOptionsButton;
    public GameObject RandomAssetsButton;

    public void DeactivateButtons()
    {
        PurpleSpotsPaper.SetActive(false);
        PurpleStripesPaper.SetActive(false);
        PurplePatternPaper.SetActive(false);
        PurpleFlowerPaper.SetActive(false);
        LilacPaper.SetActive(false);

        CatOptionsButton.SetActive(false);
        RandomAssetsButton.SetActive(false);

    }

    public void ActivateButtons()
    {
        //ColorfulPaperPink.SetActive(true);
        //ColorfulPaperBlue.SetActive(true);
        //FlowerOptions.SetActive(true);
        PatternOptions.SetActive(true);
        //SpotsOptions.SetActive(true);
        //StripesOptions.SetActive(true);

        //PurpleSpotsPaper.SetActive(true);
        //PurpleStripesPaper.SetActive(true);
        //PurplePatternPaper.SetActive(true);
        //PurpleFlowerPaper.SetActive(true);
        //LilacPaper.SetActive(true);

        BluePatternPaper.SetActive(true);
        GreenPatternPaper.SetActive(true);
        PurplePatternPaperTwo.SetActive(true);
        RedPatternPaper.SetActive(true);
        OrangePatternPaper.SetActive(true);
        YellowPatternPaper.SetActive(true);
    }

    public void PurplePattern()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
