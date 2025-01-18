using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject backButton;

    public GameObject BlueStripesPaper;
    public GameObject GreenStripesPaper;
    public GameObject RedStripesPaper;
    public GameObject PurpleStripesPaper;

    public GameObject BlueSpotsPaper;
    public GameObject GreenSpotsPaper;
    public GameObject RedSpotsPaper;
    public GameObject PurpleSpotsPaper;

    public GameObject BrightOrangeFlowerPaper;
    public GameObject BluePurpleFlowerPaper;
    public GameObject DarkPurpleFlowerPaper;
    public GameObject OrangeFlowerPaper;
    public GameObject RedFlowerPaper;
    public GameObject RedOrangeFlowerPaper;
    public GameObject RedPurpleFlowerPaper;
    public GameObject RedYellowFlowerPaper;
    public GameObject PurpleFlowerPaper;

    public GameObject BluePatternPaper;
    public GameObject GreenPatternPaper;
    public GameObject PurplePatternPaperTwo;
    public GameObject RedPatternPaper;
    public GameObject OrangePatternPaper;
    public GameObject YellowPatternPaper;

    public GameObject AquaPaper;
    public GameObject BluePaper;
    public GameObject Blue2Paper;
    public GameObject DarkPinkPaper;
    public GameObject GreenPaper;
    public GameObject MintBluePaper;
    public GameObject PinkPaper;
    public GameObject Pink2Paper;
    public GameObject PurplePaper;
    public GameObject SkyeBluePaper;
    public GameObject YellowPaper;
    public GameObject Yellow2Paper;
    public GameObject LilacPaperTwo;
    public GameObject LilacPaper;

    public GameObject PurpleSpotsPaperBack;
    public GameObject PurpleStripesPaperBack;
    public GameObject PurplePatterPaperBack;
    public GameObject PurpleFlowerPaperBack;
    public GameObject LilacPaperBack;

    public void whenButtonClicked()
    {
        if (backButton.activeInHierarchy == true)
            backButton.SetActive(false);
        else
            backButton.SetActive(true);

        deactivatePaperOptions();
    }

    public void deactivatePaperOptions()
    {
        BlueStripesPaper.SetActive(false);
        GreenStripesPaper.SetActive(false);
        RedStripesPaper.SetActive(false);

        BlueSpotsPaper.SetActive(false);
        GreenSpotsPaper.SetActive(false);
        RedSpotsPaper.SetActive(false);

        BrightOrangeFlowerPaper.SetActive(false);
        BluePurpleFlowerPaper.SetActive(false);
        DarkPurpleFlowerPaper.SetActive(false);
        OrangeFlowerPaper.SetActive(false);
        RedFlowerPaper.SetActive(false);
        RedOrangeFlowerPaper.SetActive(false);
        RedPurpleFlowerPaper.SetActive(false);
        RedYellowFlowerPaper.SetActive(false);

        BluePatternPaper.SetActive(false);
        GreenPatternPaper.SetActive(false);
        RedPatternPaper.SetActive(false);
        OrangePatternPaper.SetActive(false);
        YellowPatternPaper.SetActive(false);

        AquaPaper.SetActive(false);
        BluePaper.SetActive(false);
        Blue2Paper.SetActive(false);
        DarkPinkPaper.SetActive(false);
        GreenPaper.SetActive(false);
        MintBluePaper.SetActive(false);
        PinkPaper.SetActive(false);
        Pink2Paper.SetActive(false);
        PurplePaper.SetActive(false);
        SkyeBluePaper.SetActive(false);
        YellowPaper.SetActive(false);
        Yellow2Paper.SetActive(false);

        PurpleSpotsPaperBack.SetActive(true);
        PurpleStripesPaperBack.SetActive(true);
        PurplePatterPaperBack.SetActive(true);
        PurpleFlowerPaperBack.SetActive(true);
        LilacPaperBack.SetActive(true);
    }

}
