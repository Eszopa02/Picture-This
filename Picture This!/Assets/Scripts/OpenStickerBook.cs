using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStickerBook : MonoBehaviour
{
    public GameObject Stickerbook;

    public void WhenButtonClicked()
    {
        if (Stickerbook.activeInHierarchy == false)
        {
            Stickerbook.SetActive(true);
        }
        else
        {
            Stickerbook.SetActive(false);
        }
    }
   
}
