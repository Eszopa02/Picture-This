using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFile : MonoBehaviour
{
    public GameObject file;


    public void whenButtonClicked()
    {
        if (file.activeInHierarchy == true)
            file.SetActive(false);
        else
            file.SetActive(true);

       
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
