using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScissorsSnipWhenHovered : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject ClosedScissors;
    public GameObject OpenScissors;

    public void OnPointerEnter(PointerEventData eventData)
    {
        ClosedScissors.SetActive(true);
        OpenScissors.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ClosedScissors.SetActive(false);
        OpenScissors.SetActive(true);
    }
}
