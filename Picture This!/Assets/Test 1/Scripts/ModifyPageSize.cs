using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ModifyPageSize : MonoBehaviour
{
    Camera cam;
    bool resizing;
    public GameObject targetSprite;
    Vector2 mouseStartPos;
    float startDistance;
    Vector3 startScale;

    void Start()
    {
        cam = Camera.main;

        resizing = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            GetTargetSprite();

        if (Input.GetMouseButtonUp(1))
            resizing = false;

        if (resizing)
            ResizeSprite();
    }

    void GetTargetSprite()
    {
        Vector2 worldPos = cam.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.down);

        if (hit.collider != null)
        {
            //if (hit.transform. CompareTag("Resizable"))
            //{
                resizing = true;
                targetSprite = hit.collider.gameObject;
                mouseStartPos = worldPos;
                startDistance = Vector2.Distance(targetSprite.transform.position, worldPos);
                startScale = targetSprite.transform.localScale;
            //}
        }
    }

    void ResizeSprite()
    {
        Vector2 newWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);

        float endDistance = Vector2.Distance(newWorldPos, targetSprite.transform.position);
        float scaleFactor = endDistance / startDistance;

        targetSprite.transform.localScale = startScale * scaleFactor;
    }
}
