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
