using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePurpleSpotButton : MonoBehaviour
{
    public GameObject PurpleSpotsPaper;
    public GameObject PurpleStripesPaper;
    public GameObject PurplePatternPaper;
    public GameObject PurpleFlowerPaper;
    public GameObject LilacPaper;

    public GameObject BlueSpotsPaper;
    public GameObject GreenSpotsPaper;
    public GameObject RedSpotsPaper;
    public GameObject PurpleSpotsCanvas;

    public GameObject ColorfulPaperBlue;
    public GameObject ColorfulPaperPink;

    public GameObject FlowerOptions;
    public GameObject PatternOptions;
    public GameObject SpotsOptions;
    public GameObject StripesOptions;

    public GameObject CatOptionsButton;
    public GameObject RandomAssetsButton;

    public void DeactivateButton()
    {
        PurpleSpotsPaper.SetActive(false);
        PurpleStripesPaper.SetActive(false);
        PurplePatternPaper.SetActive(false);
        PurpleFlowerPaper.SetActive(false);
        LilacPaper.SetActive(false);

        CatOptionsButton.SetActive(false);
        RandomAssetsButton.SetActive(false);
    }

    public void ActivateButton()
    {
        //ColorfulPaperPink.SetActive(true);
        //ColorfulPaperBlue.SetActive(true);
        //FlowerOptions.SetActive(true);
        //PatternOptions.SetActive(true);
        SpotsOptions.SetActive(true);
        //StripesOptions.SetActive(true);


        BlueSpotsPaper.SetActive(true);
        GreenSpotsPaper.SetActive(true);
        RedSpotsPaper.SetActive(true);
        PurpleSpotsCanvas.SetActive(true);
    }

    public void PurpleSpots()
    {
        DeactivateButton();

        ActivateButton();
    }
}
   
