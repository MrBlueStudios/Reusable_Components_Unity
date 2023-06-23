using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditHandler : MonoBehaviour
{
    [Serializable]
    private struct CreditType
    {
        [SerializeField] public string text;
        [SerializeField] public FontStyles FontStyles;
        [SerializeField] public Color Color;
        // min max in inspactor
        [Range(0, 1)]
        [SerializeField] public float alpha;
        [SerializeField] public float Size;
    }

    [SerializeField] private CreditType[] creditTypes;

    // start
    private void Start()
    {
        // for each credit type in credit types make an child object and add text mesh pro text to it.
        foreach (CreditType creditType in creditTypes)
        {
            // make a child object
            GameObject childObject = new GameObject();
            // layer is ui
            childObject.layer = 5;
            // set rect transform
            childObject.AddComponent<RectTransform>();
            // width is 67,7% of screen width
            // height is 4,629% of screen height
            childObject.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width * 0.677f, Screen.height * 0.05901f);
            // add text mesh pro text to it
            TextMeshProUGUI textMeshProUGUI = childObject.AddComponent<TextMeshProUGUI>();
            // set the text
            textMeshProUGUI.text = creditType.text;
            // set the font style
            textMeshProUGUI.fontStyle = creditType.FontStyles;
            // set the color
            textMeshProUGUI.color = creditType.Color;
            // set how clear the text is
            textMeshProUGUI.alpha = 
            // set the size
            textMeshProUGUI.fontSize = creditType.Size;
            // set the alignment
            textMeshProUGUI.alignment = TextAlignmentOptions.Center;
            // set the material
            textMeshProUGUI.fontMaterial = Resources.Load<Material>("Fonts & Materials/LiberationSans SDF");
            // set the parent
            childObject.transform.SetParent(transform);
        }
    }

    // update
    private void Update()
    {
    }
    
}
