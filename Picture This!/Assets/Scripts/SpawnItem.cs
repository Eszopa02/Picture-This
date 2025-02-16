using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    //Colorful Pages
    public GameObject PaperSelect;






    public void ActivatePaper()
    {
        //PaperSelect.SetActive(true);
        Instantiate(PaperSelect, new Vector3(-43f, -8f, 0f), Quaternion.identity);

    }



    public void Paper()
    {
        ActivatePaper();
    }
}
