using Assets.Scripts.Buttonhandling;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    private Vector2 _screenSize;

    private List<GameObject> _buttons = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // get screen size
        _screenSize = new Vector2(Screen.width, Screen.height);
    }

    // Update is called once per frame
    void Update()
    {

    }


    // private create button method
    [SerializeField]
    GameObject CreateButton(ButtonBase currentButton, Vector2 buttonSize, Vector2 buttonPos, int currentButtonCount, string buttonText, int fontSize, List<Color> color, Color textColor)
    {
        // create button
        GameObject button = new GameObject("Button" + currentButtonCount);
        // add button component
        button.AddComponent<Button>();
        // set parent
        button.transform.SetParent(this.transform);
        // set position
        button.transform.position = buttonPos;
        // set size
        button.transform.localScale = buttonSize;
        // set text
        button.GetComponentInChildren<Text>().text = buttonText;
        // set font size
        button.GetComponentInChildren<Text>().fontSize = fontSize;
        // set color
        button.GetComponentInChildren<Text>().color = textColor;

        // set the states of the button
        button.GetComponent<Button>().transition = Selectable.Transition.ColorTint;
        // set the normal color
        button.GetComponent<Button>().colors = new ColorBlock() { normalColor = color[0], highlightedColor = color[1], pressedColor = color[2], disabledColor = Color.red };

        // add the button script
        button.AddComponent(currentButton.GetType());

        // return the button
        return button;
    }

    // create buttons method. we will have 3 different create buttons methods
    // 1. create buttons with the same size and make them fit the screen size
    private void CreateButtonsEqually(GameObject button, int amountButtons, Vector2 paddingInside, Vector2 paddingOutside)
    {
        // get the size of the buttons
        Vector2 buttonSize = new Vector2((_screenSize.x - (paddingOutside.x * 2) - (paddingInside.x * (amountButtons - 1))) / amountButtons, (_screenSize.y - (paddingOutside.y * 2) - (paddingInside.y * (amountButtons - 1))) / amountButtons);
        // get the position of the first button
        Vector2 buttonPos = new Vector2(paddingOutside.x, paddingOutside.y);
        // get the amount of buttons
        int currentButtonCount = 0;
        // get the button text
        string buttonText = button.GetComponentInChildren<Text>().text;
        // get the font size
        int fontSize = button.GetComponentInChildren<Text>().fontSize;
        // get the colors


    }
}
