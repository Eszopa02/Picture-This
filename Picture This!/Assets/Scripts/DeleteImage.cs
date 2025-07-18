using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DeleteImage : MonoBehaviour, IDropHandler
{
    //public GameObject OpenTrash;
    //public GameObject ClosedTrash;

    public void OnDrop(PointerEventData eventData)
    {
        //OpenTrash.SetActive(true);
        
        if (eventData.pointerDrag != null)
        {
            DragImage droppedObject = eventData.pointerDrag.GetComponent<DragImage>();

            //OpenTrash.SetActive(false);

            if (droppedObject != null)
            {
                //OpenTrash.SetActive(true);

                Destroy(droppedObject.gameObject); //
                Debug.Log("Prefab destroyed upon dropping on the image!");


                //OpenTrash.SetActive(true);
                //ClosedTrash.SetActive(false);
            }
            
        }


    }
}