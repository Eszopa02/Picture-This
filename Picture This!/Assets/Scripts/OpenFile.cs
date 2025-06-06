using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFile : MonoBehaviour
{
    public GameObject file;

    public GameObject ColorfulPaperBlue;
    public GameObject ColorfulPaperPink;

    public GameObject FlowerOptions;
    public GameObject PatternOptions;
    public GameObject SpotsOptions;
    public GameObject StripesOptions;

    public GameObject PurpleSpotsPaper;
    public GameObject PurpleStripesPaper;
    public GameObject PurpleFlowerPaper;
    public GameObject PurplePatternPaper;
    public GameObject LilacPaper;
    public GameObject PurpleFlowerCanvas;

    public GameObject CatOptionsButton;
    public GameObject RandomAssetsButton;
    public GameObject DogOptionsButton;

    public GameObject CatOptions;
    public GameObject RandomOptions;
    public GameObject DogOptions;

    public GameObject PaperOptions;

    public GameObject StickerOptions;

    public void whenButtonClicked()
    {
        if (file.activeInHierarchy == true)
        {
            file.SetActive(false);

            PurpleSpotsPaper.SetActive(true);
            PurpleStripesPaper.SetActive(true);
            PurplePatternPaper.SetActive(true);
            PurpleFlowerPaper.SetActive(true);
            LilacPaper.SetActive(true);

            CatOptionsButton.SetActive(true);
            RandomAssetsButton.SetActive(true);
            DogOptionsButton.SetActive(true);

            CatOptions.SetActive(false);
            RandomOptions.SetActive(false);
            DogOptions.SetActive(false);


            ColorfulPaperBlue.SetActive(false);
            ColorfulPaperPink.SetActive(false);

            FlowerOptions.SetActive(false);
            PatternOptions.SetActive(false);
            SpotsOptions.SetActive(false);
            StripesOptions.SetActive(false);
        }
        else
        {
            file.SetActive(true);

            ColorfulPaperBlue.SetActive(false);
            ColorfulPaperPink.SetActive(false);

            FlowerOptions.SetActive(false);
            PatternOptions.SetActive(false);
            SpotsOptions.SetActive(false);
            StripesOptions.SetActive(false);

            CatOptions.SetActive(false);
            RandomOptions.SetActive(false);
            DogOptions.SetActive(false);
        }
            
            

       
    }

}
