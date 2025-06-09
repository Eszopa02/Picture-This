using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePurpleFlowerButton : MonoBehaviour
{
    public GameObject BrightOrangeFlowerPaper;
    public GameObject BluePurpleFlowerPaper;
    public GameObject DarkPurpleFlowerPaper;
    public GameObject OrangeFlowerPaper;
    public GameObject RedPurpleFlowerPaper;
    public GameObject RedYellowFlowerPaper;

    public GameObject PurpleSpotsPaperDeactivate;
    public GameObject PurpleStripesPaperDeactivate;
    public GameObject PurpleFlowerPaperDeactivate;
    public GameObject PurplePatternPaperDeactivate;
    public GameObject LilacPaperDeactivate;

    public GameObject ColorfulPaperBlue;
    public GameObject ColorfulPaperPink;

    public GameObject FlowerOptions;
    public GameObject PatternOptions;
    public GameObject SpotsOptions;
    public GameObject StripesOptions;


    public void DeactivateButtons()
    {
        PurpleSpotsPaperDeactivate.SetActive(false);
        PurpleStripesPaperDeactivate.SetActive(false);
        PurplePatternPaperDeactivate.SetActive(false);
        PurpleFlowerPaperDeactivate.SetActive(false);
        LilacPaperDeactivate.SetActive(false);


    }

    public void ActivateButtons()
    {

        FlowerOptions.SetActive(true);


        BrightOrangeFlowerPaper.SetActive(true);
        BluePurpleFlowerPaper.SetActive(true);
        DarkPurpleFlowerPaper.SetActive(true);
        OrangeFlowerPaper.SetActive(true);
        RedPurpleFlowerPaper.SetActive(true);
        RedYellowFlowerPaper.SetActive(true);
    }

    public void PurpleFlower()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
