using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public Image targetImage;
    public Sprite newImage;

    public void ChangeImage()
    {
        targetImage.sprite = newImage;
    }
}
