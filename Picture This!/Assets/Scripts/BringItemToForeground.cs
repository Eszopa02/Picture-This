using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BringItemToForeground : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Canvas myCanvas;


    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hovered over object");
        myCanvas.sortingOrder = 10;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        myCanvas.sortingOrder = 1;
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
