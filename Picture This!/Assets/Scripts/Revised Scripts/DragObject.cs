using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface ICustomDrag
{
    void OnCurrentDrag();
}

public class DragObject : MonoBehaviour, IDragHandler
{
    public GameObject objectToInteractWith;
    private ICustomDrag onDrag;

    void Start()
    {
        onDrag = objectToInteractWith.GetComponent<ICustomDrag>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        onDrag.OnCurrentDrag();
    }
}
