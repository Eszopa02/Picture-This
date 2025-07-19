using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public Image rightImage;
    public Image leftImage;
    public Sprite newImage;

    public void ChangeImage()
    {
        rightImage.sprite = newImage;
        leftImage.sprite = newImage;
    }
}
