using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StickerScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private float zoomRate = 0.1f; 
    [SerializeField] private float minScale = 0.5f; 
    [SerializeField] private float maxSize = 2.0f; 

    private bool mouseOverImage = false; 

    void Update()
    {
  
        if (mouseOverImage && Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            float scrollWheelInput = Input.GetAxis("Mouse ScrollWheel");

 
            Vector3 currentScale = transform.localScale;
            float newScaleFactor = currentScale.x; 

            if (scrollWheelInput > 0) 
            {
                newScaleFactor *= (1 + zoomRate);
            }
            else if (scrollWheelInput < 0) 
            {
                newScaleFactor /= (1 + zoomRate);
            }

            
            newScaleFactor = Mathf.Clamp(newScaleFactor, minScale, maxSize);

            
            transform.localScale = new Vector3(newScaleFactor, newScaleFactor + 1, 1);
        }
    }

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseOverImage = true;
    }

    
    public void OnPointerExit(PointerEventData eventData)
    {
        mouseOverImage = false;
    }
}
