using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.MySettings
{

    public enum InputMode
    {
        KeyboardMouse,
        Controller
    }

    [Serializable]
    public class KeybindData
    {
        public string actionName;
        public KeyCode keyCode;
    }

    [CreateAssetMenu(fileName = "KeybindSettings", menuName = "MrBlueAssets[By:Léon]/Settings/Keybind Settings")]
    public class KeybindSettings : ScriptableObject
    {
        public InputMode inputMode = InputMode.KeyboardMouse;
        public List<KeybindData> keybinds = new List<KeybindData>();
    }
    /*    [CreateAssetMenu(fileName = "KeybindSettings", menuName = "MrBlueAssets[By:Léon]/Settings/Keybind Settings")]
        public class KeybindSettings : ScriptableObject
        {


            [SerializeField] private InputMode inputMode = InputMode.KeyboardMouse;

            public InputMode InputMode => inputMode; // Public getter for inputMode

            [Header("Keyboard/Mouse Keybinds")]
            [SerializeField] private KeyCode keyboardMouse_jumpKey = KeyCode.Space;
            [SerializeField] private KeyCode keyboardMouse_sprintKey = KeyCode.LeftShift;
            // ... (other keyboard/mouse keybinds)

            [Header("Controller Keybinds")]
            [SerializeField] private KeyCode controller_jumpKey = KeyCode.JoystickButton0;
            [SerializeField] private KeyCode controller_sprintKey = KeyCode.JoystickButton8;

            public string GetKeyCodePropertyName(InputMode inputMode, string keyName)
            {
                return inputMode.ToString() + "_" + keyName;
            }
            // ... (other controller keybinds)
            *//*        [SerializeField] protected KeyCode jumpKey      =   KeyCode.Space;
                    [SerializeField] protected KeyCode sprintKey    =   KeyCode.LeftShift;
                    [SerializeField] protected KeyCode crouchKey    =   KeyCode.LeftControl;
                    [SerializeField] protected KeyCode interactKey  =   KeyCode.E;
                    [SerializeField] protected KeyCode inventoryKey =   KeyCode.I;
                    [SerializeField] protected KeyCode pauseKey     =   KeyCode.Escape;
                    [SerializeField] protected KeyCode attackKey    =   KeyCode.Mouse0;
                    *//*
        }// maybe also make custom settings for */
}
/*public enum InputMode// probably want to make the input 
{
    KeyboardMouse,
    Controller
    //,Touchscreen
}*/