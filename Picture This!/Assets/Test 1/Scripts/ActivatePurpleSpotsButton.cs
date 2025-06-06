using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePurpleSpotsButton : MonoBehaviour
{


    public GameObject PurpleSpotsPaper;
    public GameObject PurpleStripesPaper;
    public GameObject PurplePatternPaper;
    public GameObject PurpleFlowerPaper;
    public GameObject LilacPaper;

    public GameObject BlueSpotsPaper;
    public GameObject GreenSpotsPaper;
    public GameObject PurpleSpotsPaperTwo;
    public GameObject RedSpotsPaper;

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
        BlueSpotsPaper.SetActive(true);
        GreenSpotsPaper.SetActive(true);
        PurpleSpotsPaperTwo.SetActive(true);
        RedSpotsPaper.SetActive(true);
    }

    public void PurpleSpotsPaperButton()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
   
