using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WHToSceenSize : MonoBehaviour
{
    // set wicht and height of the object that has this script to the screen size
    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
    }   
}
