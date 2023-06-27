using System;
using UnityEngine;
using TMPro;
using Assets.Scripts.HandelingCredits.TheCredits;
using Assets.Scripts;

public class CreditHandler : MonoBehaviour
{
    // tmppro font
    [SerializeField] private TMP_FontAsset font;

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
        [SerializeField] private CreditType[] creditTypes;

    }
    [SerializeField] private CreditType[] creditTypes;

    

    private ThanksPlayer thanksPlayer;
    // start
    private void Start()
    {
        
        // add colorchange to thanksplayer


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
            childObject.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width * 0.677f, creditType.Size + 15);
            // add text mesh pro text to it
            TextMeshProUGUI textMeshProUGUI = childObject.AddComponent<TextMeshProUGUI>();
            // set the text
            textMeshProUGUI.text = creditType.text;
            // set the font style
            textMeshProUGUI.fontStyle = creditType.FontStyles;
            // set the color
            textMeshProUGUI.color = creditType.Color;
            // set how clear the text is
            textMeshProUGUI.alpha = creditType.alpha;
            // set the size
            textMeshProUGUI.fontSize = creditType.Size;
            // set the alignment
            textMeshProUGUI.alignment = TextAlignmentOptions.Bottom;

            // if the font is null
            if (font == null)
            {
                // load default font
                font = Resources.Load<TMP_FontAsset>("Fonts & Materials/LiberationSans SDF");
            }

            // set the material
            textMeshProUGUI.font = font;
            // set the parent
            childObject.transform.SetParent(transform);
        }
        // get thanksplayer
        thanksPlayer = new ThanksPlayer();
        // thank the player
        thanksPlayer.ThxCredit(transform);

    }

    private void Awake()
    {
        if(buttonHandler == null)
            // set the button handler by getting it from its parents parent
            buttonHandler = transform.parent.parent.GetComponent<ButtonHandler>();
    }

    [SerializeField] 
    private ButtonHandler buttonHandler;

    // update
    private void Update()
    {
        // if the player presses any key
        if (Input.anyKeyDown)
        {
            buttonHandler.GoBack();
            
        }
    }
    


}
