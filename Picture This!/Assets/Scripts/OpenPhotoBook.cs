using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPhotoBook : MonoBehaviour
{
  public GameObject PhotoBook;

    public GameObject PhotoOne;
    public GameObject PhotoTwo;
    public GameObject PhotoThree;
    public GameObject PhotoFour;


    public void WhenButtonClicked()
    {
        if (PhotoBook.activeInHierarchy == true)
        {
            PhotoBook.SetActive(false);
        }
        else
        {
            PhotoBook.SetActive(true);
        }

        

    }
}
