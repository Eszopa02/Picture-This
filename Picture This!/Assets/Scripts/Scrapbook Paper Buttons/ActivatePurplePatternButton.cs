using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePurplePatternButtons : MonoBehaviour
{
    public GameObject PurpleSpotsPaperDeactivate;
    public GameObject PurpleStripesPaperDeactivate;
    public GameObject PurplePatternPaperDeactivate;
    public GameObject PurpleFlowerPaperDeactivate;
    public GameObject LilacPaperDeactivate;

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

        PatternOptions.SetActive(true);


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
