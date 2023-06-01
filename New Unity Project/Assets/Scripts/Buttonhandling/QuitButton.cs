using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Buttonhandling
{
    // quit button
    public class QuitButton : ButtonBase
    {
        // on awake
        protected override void Awake()
        {
            // set the button text
            GetComponentInChildren<Text>().text = "Quit";

            // call base
            base.Awake();
        }

        // on click
        protected override void OnClick()
        {
            // quit game
            Application.Quit();
        }
    }
}