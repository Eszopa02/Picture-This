using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowedMode : MonoBehaviour
{
    public void OnButtonPress()
    {
        Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
    }
}
