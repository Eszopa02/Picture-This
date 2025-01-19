using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateColorfulPaperButton : MonoBehaviour
{
    public GameObject AquaPaper;
    public GameObject BluePaper;
    public GameObject Blue2Paper;
    public GameObject DarkPinkPaper;
    public GameObject GreenPaper;
    public GameObject MintBluePaper;
    public GameObject PinkPaper;
    public GameObject Pink2Paper;
    public GameObject PurplePaper;
    public GameObject SkyeBluePaper;
    public GameObject YellowPaper;
    public GameObject Yellow2Paper;
    public GameObject LilacPaperTwo;

    public GameObject PurpleSpotsPaper;
    public GameObject PurpleStripesPaper;
    public GameObject PurpleFlowerPaper;
    public GameObject PurplePatternPaper;
    public GameObject LilacPaper;

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
        ColorfulPaperPink.SetActive(true);
        ColorfulPaperBlue.SetActive(true);
        //FlowerOptions.SetActive(true);
        //PatternOptions.SetActive(true);
        //SpotsOptions.SetActive(true);
        //StripesOptions.SetActive(true);


        AquaPaper.SetActive(true);
        BluePaper.SetActive(true);
        Blue2Paper.SetActive(true);
        DarkPinkPaper.SetActive(true);
        GreenPaper.SetActive(true);
        LilacPaper.SetActive(true);
        MintBluePaper.SetActive(true);
        PinkPaper.SetActive(true);
        Pink2Paper.SetActive(true);
        PurplePaper.SetActive(true);
        SkyeBluePaper.SetActive(true);
        YellowPaper.SetActive(true);
        Yellow2Paper.SetActive(true);
    }

    public void ColorfulPaper()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
