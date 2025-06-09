using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconStickers : MonoBehaviour
{
    public GameObject CatOptionsButton;
    public GameObject RandomAssetsButton;
    public GameObject DogOptionsButton;
    public GameObject LowercaseLettersButton;
    public GameObject CapitalLettersButton;

    public GameObject BlueFlower;
    public GameObject BourBlue;
    public GameObject KiraiKirai;
    public GameObject Leaf;
    public GameObject Leaves;
    public GameObject OrangeFlower;
    public GameObject PinkFlower;
    public GameObject PurpleFlower;
    public GameObject Tulips;

    public void DeactivateButtons()
    {
        CatOptionsButton.SetActive(false);
        RandomAssetsButton.SetActive(false);
        DogOptionsButton.SetActive(false);
        LowercaseLettersButton.SetActive(false);
        CapitalLettersButton.SetActive(false);

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
        Tulips.SetActive(true);

    }

    public void RandomButton()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
