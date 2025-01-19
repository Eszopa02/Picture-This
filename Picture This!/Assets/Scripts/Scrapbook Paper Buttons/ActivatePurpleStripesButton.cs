using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePurpleStripesButton : MonoBehaviour
{
    public GameObject PurpleSpotsPaper;
    public GameObject PurpleStripesPaper;
    public GameObject PurplePatternPaper;
    public GameObject PurpleFlowerPaper;
    public GameObject LilacPaper;

    public GameObject BlueStripesPaper;
    public GameObject GreenStripesPaper;
    public GameObject RedStripesPaper;
    public GameObject PurpleStripesCanvas;

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
        //FlowerOptions.SetActive(true);
        //PatternOptions.SetActive(true);
        //SpotsOptions.SetActive(true);
        StripesOptions.SetActive(true);


        BlueStripesPaper.SetActive(true);
        GreenStripesPaper.SetActive(true);
        RedStripesPaper.SetActive(true);
        PurpleStripesCanvas.SetActive(true);
    }

    public void PurpleStripes()
    {
        DeactivateButtons();

        ActivateButtons();

    }

}
