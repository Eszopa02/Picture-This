using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PenClick : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject OpenPen;
    public GameObject ClosedPen;
    public GameObject SettingText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (SettingText.activeInHierarchy == true)
        {
            ClosedPen.SetActive(false);
            OpenPen.SetActive(true);
        }
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ClosedPen.SetActive(true);
        OpenPen.SetActive(false);
    }
}
