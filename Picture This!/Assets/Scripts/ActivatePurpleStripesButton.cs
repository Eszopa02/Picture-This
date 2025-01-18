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
    public GameObject PurpleStripesPaperTwo;
    public GameObject RedStripesPaper;

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
        BlueStripesPaper.SetActive(true);
        GreenStripesPaper.SetActive(true);
        PurpleStripesPaperTwo.SetActive(true);
        RedStripesPaper.SetActive(true);
    }

    public void PurpleSpotsPaperButton()
    {
        DeactivateButtons();

        ActivateButtons();
    }

}
