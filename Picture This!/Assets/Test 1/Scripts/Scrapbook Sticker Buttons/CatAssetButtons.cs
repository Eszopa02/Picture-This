using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAssetButtons : MonoBehaviour
{

    public GameObject JJHead;
    public GameObject MartiniHead;
    public GameObject SiameseHead;
    public GameObject TabbyHead;
    public GameObject VoidHead;
    public GameObject WhiteCat;

    public GameObject PurpleSpotsPaper;
    public GameObject PurpleStripesPaper;
    public GameObject PurpleFlowerPaper;
    public GameObject PurplePatternPaper;
    public GameObject LilacPaper;

    public GameObject CatOptionsButton;
    public GameObject RandomAssetsButton;
    public GameObject DogOptionsButton;

    public GameObject CatOptions;
    public GameObject RandomOptions;
    public GameObject DogOptions;

    public void DeactivateButtons()
    {
        PurpleSpotsPaper.SetActive(false);
        PurpleStripesPaper.SetActive(false);
        PurplePatternPaper.SetActive(false);
        PurpleFlowerPaper.SetActive(false);
        LilacPaper.SetActive(false);

        CatOptionsButton.SetActive(false);
        RandomAssetsButton.SetActive(false);
        DogOptionsButton.SetActive(false);

    }

    public void ActivateButtons()
    {
        JJHead.SetActive(true);
        MartiniHead.SetActive(true);
        SiameseHead.SetActive(true);
        TabbyHead.SetActive(true);
        VoidHead.SetActive(true);
        WhiteCat.SetActive(true);

        CatOptions.SetActive(true);

    }

    public void CatButton()
    {
        DeactivateButtons();

        ActivateButtons();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
