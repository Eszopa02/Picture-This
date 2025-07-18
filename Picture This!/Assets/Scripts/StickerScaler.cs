using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerScaler : MonoBehaviour
{
    public float zoomSpeed = 1.0f;
    public float minSize = 0.1f;
    public float maxSize = 5.0f;

    private Vector3 initialScale;

    void Start()
    {
        initialScale = transform.localScale;
    }


    void Update()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        if (scrollInput != 0)
        {
            Vector3 currentScale = transform.localScale;
            float newXScale = currentScale.x + scrollInput * zoomSpeed;
            float newYScale = currentScale.y + scrollInput * zoomSpeed;
            float newZScale = currentScale.z + scrollInput * zoomSpeed;

            newXScale = Mathf.Clamp(newXScale, initialScale.x * minSize, initialScale.x * maxSize);
            newYScale = Mathf.Clamp(newYScale, initialScale.y * minSize, initialScale.y * maxSize);
            newZScale = Mathf.Clamp(newZScale, initialScale.z * minSize, initialScale.z * maxSize);

            transform.localScale = new Vector3(newXScale, newYScale, newZScale);
        }
    }
}
