using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DeleteImage : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            DragImage droppedObject = eventData.pointerDrag.GetComponent<DragImage>();

            if (droppedObject != null)
            {

                Destroy(droppedObject.gameObject); //
                Debug.Log("Prefab destroyed upon dropping on the image!");
            }
        }


    }
}