using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragImage : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler
{
    private Vector2 mousePosition = new Vector2();
    private Vector2 startPosition = new Vector2();
    private Vector2 differencePoint = new Vector2();
    public RectTransform imageTransform;
    public Camera mainCamera;

    void Update()
    {
        //if(Input.GetMouseButton(0))
        //{
            //UpdateMousePosition();
        //}
        //if (Input.GetMouseButtonDown(0))
        //{
            //UpdateStartPosition();
            //UpdateDifferencePoint();
        //}
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Image pressed!");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Image dragged!");

        //transform.position = mousePosition - differencePoint;

        Vector3 mousePos = Input.mousePosition;

        Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        worldPos.z = 0;

        imageTransform.position = worldPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Image dropped!");
    }

    private void UpdateMousePosition()
    {
        mousePosition.x = Input.mousePosition.x;
        mousePosition.y = Input.mousePosition.y;
    }

    private void UpdateStartPosition()
    {
        startPosition.x = transform.position.x;
        startPosition.y = transform.position.y;
    }

    private void UpdateDifferencePoint()
    {
        differencePoint = mousePosition - startPosition;
    }
}