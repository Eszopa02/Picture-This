using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSelect : MonoBehaviour
{
    public GameObject SelectedPaper;

    public void ActivatePaper()
    {
        Instantiate(SelectedPaper, new Vector3(-43f, -8f, 0f), Quaternion.identity);
        Debug.Log("Spawned Paper");
    }

    public void Paper()
    {
        ActivatePaper();
    }
}
