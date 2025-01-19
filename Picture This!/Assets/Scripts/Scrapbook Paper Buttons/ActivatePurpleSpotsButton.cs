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

    public void DeactivateButton()
    {
        PurpleSpotsPaper.SetActive(false);
        PurpleStripesPaper.SetActive(false);
        PurplePatternPaper.SetActive(false);
        PurpleFlowerPaper.SetActive(false);
        LilacPaper.SetActive(false);
    }

    public void ActivateButton()
    {
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
   
