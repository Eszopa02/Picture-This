using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSortingLayerOnHover : MonoBehaviour
{
    public string hoverSortingLayer = "Foreground";

    void OnMouseEver()
    {
        Rendered renderer = GetComponent<renderer>();

        renderer.sortingLayerName = hoverSortingLayer;
    }

    void OnMouseExit()
    {
        Renderer renderer = GetComponent<Renderer>();

        renderer.sortingLayerName = "Background";
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
