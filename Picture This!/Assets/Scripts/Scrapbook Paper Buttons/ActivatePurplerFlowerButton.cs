using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePurpleFlowerButton : MonoBehaviour
{
    public GameObject BrightOrangeFlowerPaper;
    public GameObject BluePurpleFlowerPaper;
    public GameObject DarkPurpleFlowerPaper;
    public GameObject OrangeFlowerPaper;
    public GameObject RedFlowerPaper;
    public GameObject RedOrangeFlowerPaper;
    public GameObject RedPurpleFlowerPaper;
    public GameObject RedYellowFlowerPaper;

    public GameObject PurpleSpotsPaper;
    public GameObject PurpleStripesPaper;
    public GameObject PurpleFlowerPaper;
    public GameObject PurplePatternPaper;
    public GameObject LilacPaper;
    public GameObject PurpleFlowerCanvas;

    public GameObject ColorfulPaperBlue;
    public GameObject ColorfulPaperPink;

    public GameObject FlowerOptions;
    public GameObject PatternOptions;
    public GameObject SpotsOptions;
    public GameObject StripesOptions;

    public void DeactivateButtons()
    {
        PurpleSpotsPaper.SetActive(false);
        PurpleStripesPaper.SetActive(false);
        PurplePatternPaper.SetActive(false);
        PurpleFlowerPaper.SetActive(false);
        LilacPaper.SetActive(false);

    }

    public void ActivateButtons()
    {
        //ColorfulPaperPink.SetActive(true);
        //ColorfulPaperBlue.SetActive(true);
        FlowerOptions.SetActive(true);
        //PatternOptions.SetActive(true);
        //SpotsOptions.SetActive(true);
        //StripesOptions.SetActive(true);


        BrightOrangeFlowerPaper.SetActive(true);
        BluePurpleFlowerPaper.SetActive(true);
        DarkPurpleFlowerPaper.SetActive(true);
        OrangeFlowerPaper.SetActive(true);
        RedFlowerPaper.SetActive(true);
        RedOrangeFlowerPaper.SetActive(true);
        RedPurpleFlowerPaper.SetActive(true);
        RedYellowFlowerPaper.SetActive(true);
        PurpleFlowerCanvas.SetActive(true);
    }

    public void PurpleFlower()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
