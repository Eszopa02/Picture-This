using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ModifyPageSize : MonoBehaviour
{
    public Image targetImage;

    void Update()
    {
        float scrollDelta = Input.GetAxis("Mouse ScrollWheel");

        Vector3 newScale = targetImage.rectTransform.localScale;

        newScale.x += scrollDelta * 0.1f;

        newScale.y += scrollDelta * 0.1f;

        targetImage.rectTransform.localScale = newScale;
    }

    
}
