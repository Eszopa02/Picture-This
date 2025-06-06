using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StickyNotesFold : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject ActivateCurledNote;
    public GameObject StickyNote;

    public void OnPointerEnter(PointerEventData eventData)
    {
        ActivateCurledNote.SetActive(true);
        StickyNote.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ActivateCurledNote.SetActive(false);
        StickyNote.SetActive(true);
    }
   /* public GameObject stickyNoteCurled;
    public GameObject stickyNote;

    public GameObject pointerEnter;

    void OnMouseOver()
    {
        Debug.Log("Mouse is over sticky note");
        if (stickyNote.activeInHierarchy == true)
            stickyNote.SetActive(false);
        else
            stickyNote.SetActive(true);
    }

    public void OnPointerEnter(pointerEnter eventData)
    {
        Debug.Log("Mouse is over sticky note");
    }

    void OnMouseExit()
    {
        
    }

    */
}
