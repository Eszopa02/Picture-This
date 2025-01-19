using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPaperOptions : MonoBehaviour
{
    public GameObject file;

    public GameObject ColorfulPaperBlue;
    public GameObject ColorfulPaperPink;

    public GameObject FlowerOptions;
    public GameObject PatternOptions;
    public GameObject SpotsOptions;
    public GameObject StripesOptions;


    public void whenButtonClicked()
    {
        if (file.activeInHierarchy == true)
            file.SetActive(false);
        else
            file.SetActive(true);


    }
}
