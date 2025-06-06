using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAssetButton : MonoBehaviour
{

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

    public GameObject BlueFlower;
    public GameObject BourBlue;
    public GameObject KiraiKirai;
    public GameObject Leaf;
    public GameObject Leaves;
    public GameObject OrangeFlower;
    public GameObject PinkFlower;
    public GameObject PurpleFlower;
    public GameObject Stars;
    public GameObject Tulips;

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
        BlueFlower.SetActive(true);
        BourBlue.SetActive(true);
        KiraiKirai.SetActive(true);
        Leaf.SetActive(true);
        Leaves.SetActive(true);
        OrangeFlower.SetActive(true);
        PinkFlower.SetActive(true);
        PurpleFlower.SetActive(true);
        Stars.SetActive(true);
        Tulips.SetActive(true);

        RandomOptions.SetActive(true);

    }

    public void RandomButton()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
