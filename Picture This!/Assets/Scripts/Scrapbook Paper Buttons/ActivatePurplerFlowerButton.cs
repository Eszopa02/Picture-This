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
        BrightOrangeFlowerPaper.SetActive(true);
        BluePurpleFlowerPaper.SetActive(true);
        DarkPurpleFlowerPaper.SetActive(true);
        OrangeFlowerPaper.SetActive(true);
        PurpleFlowerPaper.SetActive(true);
        RedFlowerPaper.SetActive(true);
        RedOrangeFlowerPaper.SetActive(true);
        RedPurpleFlowerPaper.SetActive(true);
        RedYellowFlowerPaper.SetActive(true);
    }

    public void PurpleFlower()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
