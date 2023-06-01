using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Buttonhandling
{
    using UnityEngine;
    using UnityEngine.UI;

    public abstract class ButtonBase : MonoBehaviour
    {
        private Button button;

        protected virtual void Awake()
        {
            // Get a reference to the button component attached to this game object
            button = GetComponent<Button>();

            // Add an event listener to the button click event
            button.onClick.AddListener(OnClick);
        }

        protected virtual void OnDestroy()
        {
            // Remove the event listener when the button is destroyed
            button.onClick.RemoveListener(OnClick);
        }

        protected abstract void OnClick();
    }
}
