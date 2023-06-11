using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthoSwitch : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // switch to orthographic view
        if (Input.GetKeyDown(KeyCode.O))
        {
            UnityEngine.Camera.main.orthographic = true;
        }
        // switch to perspective view
        if (Input.GetKeyDown(KeyCode.P))
        {
            UnityEngine.Camera.main.orthographic = false;
        }
    }
}