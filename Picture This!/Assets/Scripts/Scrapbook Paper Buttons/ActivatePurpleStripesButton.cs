using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePurpleStripesButton : MonoBehaviour
{
    public GameObject PurpleSpotsPaperDeactivate;
    public GameObject PurpleStripesPaperDeactivate;
    public GameObject PurplePatternPaperDeactivate;
    public GameObject PurpleFlowerPaperDeactivate;
    public GameObject LilacPaperDeactivate;

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
        PurpleSpotsPaperDeactivate.SetActive(false);
        PurpleStripesPaperDeactivate.SetActive(false);
        PurplePatternPaperDeactivate.SetActive(false);
        PurpleFlowerPaperDeactivate.SetActive(false);
        LilacPaperDeactivate.SetActive(false);
    }

    public void ActivateButtons()
    {
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
