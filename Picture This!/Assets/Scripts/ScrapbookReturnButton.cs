using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapbookReturnButton : MonoBehaviour
{
    public GameObject FlowerOptions;
    public GameObject PatternOptions;
    public GameObject SpotsOptions;
    public GameObject StripesOptions;
    public GameObject ColorfulOptionsRed;
    public GameObject ColorfulOptionsBlue;

    public GameObject PurpleFlower;
    public GameObject PurplePattern;
    public GameObject PurpleSpots;
    public GameObject PurpleStripes;
    public GameObject Lilac;

    public void DeactivateButtons()
    {
        FlowerOptions.SetActive(false);
        PatternOptions.SetActive(false);
        SpotsOptions.SetActive(false);
        StripesOptions.SetActive(false);
        ColorfulOptionsRed.SetActive(false);
        ColorfulOptionsBlue.SetActive(false);
    }

    public void ActivateButtons()
    {
        PurpleFlower.SetActive(true);
        PurplePattern.SetActive(true);
        PurpleSpots.SetActive(true);
        PurpleStripes.SetActive(true);
        Lilac.SetActive(true);
    }

    public void Return()
    {
        DeactivateButtons();
        ActivateButtons();
    }
}
