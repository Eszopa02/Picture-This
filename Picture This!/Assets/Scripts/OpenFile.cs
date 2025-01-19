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

            /*ColorfulPaperBlue.SetActive(false);
            ColorfulPaperPink.SetActive(false);

            FlowerOptions.SetActive(false);
            PatternOptions.SetActive(false);
            SpotsOptions.SetActive(false);
            StripesOptions.SetActive(false); */
        }
            
            

       
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
