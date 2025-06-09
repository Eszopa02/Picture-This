using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePurpleSpotButton : MonoBehaviour
{
    public GameObject PurpleSpotsPaperDeactivate;
    public GameObject PurpleStripesPaperDeactivate;
    public GameObject PurplePatternPaperDeactivate;
    public GameObject PurpleFlowerPaperDeactivate;
    public GameObject LilacPaperDeactivate;

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

    public void DeactivateButton()
    {
        PurpleSpotsPaperDeactivate.SetActive(false);
        PurpleStripesPaperDeactivate.SetActive(false);
        PurplePatternPaperDeactivate.SetActive(false);
        PurpleFlowerPaperDeactivate.SetActive(false);
        LilacPaperDeactivate.SetActive(false);
    }

    public void ActivateButton()
    {
        SpotsOptions.SetActive(true);


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
   
