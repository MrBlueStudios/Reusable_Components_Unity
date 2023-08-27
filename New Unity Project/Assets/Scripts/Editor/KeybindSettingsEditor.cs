


/*using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.MySettings
{
    [CustomEditor(typeof(KeybindSettings))]
    public class KeybindSettingsEditor : Editor
    {
        private SerializedProperty inputModeProp;
        private SerializedProperty keybindsProp;

        private void OnEnable()
        {
            inputModeProp = serializedObject.FindProperty("inputMode");
            keybindsProp = serializedObject.FindProperty("keybinds");
        }

        public override void OnInspectorGUI()
        {
            KeybindSettings keybindSettings = (KeybindSettings)target;
            serializedObject.Update();

            EditorGUILayout.PropertyField(inputModeProp);

            EditorGUILayout.Space();

            EditorGUI.indentLevel++;

            for (int i = 0; i < keybindsProp.arraySize; i++)
            {
                SerializedProperty keybindProp = keybindsProp.GetArrayElementAtIndex(i);
                KeybindData keybind = keybindSettings.keybinds[i];

                bool showKeybind = ShouldShowKeybind(keybind.actionName);

                if (showKeybind)
                {
                    EditorGUILayout.BeginHorizontal();

                    keybind.actionName = EditorGUILayout.TextField("Action Name", keybind.actionName);

                    // Display a relevant enum popup based on input mode
                    if (keybindSettings.inputMode == InputMode.KeyboardMouse)
                    {
                        keybind.keyCode = (KeyCode)EditorGUILayout.EnumPopup("Key Code", keybind.keyCode);
                    }
                    else if (keybindSettings.inputMode == InputMode.Controller)
                    {
                        keybind.keyCode = (KeyCode)EditorGUILayout.EnumPopup("Key Code", keybind.keyCode);
                    }

                    if (GUILayout.Button("Remove", GUILayout.Width(60)))
                    {
                        keybindsProp.DeleteArrayElementAtIndex(i);
                        i--; // Adjust the index since we removed an element
                    }

                    EditorGUILayout.EndHorizontal();
                }
            }

            EditorGUI.indentLevel--;

            if (GUILayout.Button("Add Keybind"))
            {
                keybindSettings.keybinds.Add(new KeybindData());
            }

            serializedObject.ApplyModifiedProperties();
        }

        private bool ShouldShowKeybind(string actionName)
        {
            // List of action names that should be shown for keyboard/mouse
            string[] keyboardMouseActions = { "Jump", "Sprint", "Interact" };

            // List of action names that should be shown for controller
            string[] controllerActions = { "Jump", "Sprint", "Interact" };

            if (keybindSettings.inputMode == InputMode.KeyboardMouse)
            {
                return keyboardMouseActions.Contains(actionName);
            }
            else if (keybindSettings.inputMode == InputMode.Controller)
            {
                return controllerActions.Contains(actionName);
            }

            return true; // Show all other keybinds
        }
    }
}*/


using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.MySettings
{
    [CustomEditor(typeof(KeybindSettings))]
    public class KeybindSettingsEditor : Editor
    {
        private SerializedProperty inputModeProp;
        private SerializedProperty keybindsProp;

        private void OnEnable()
        {
            inputModeProp = serializedObject.FindProperty("inputMode");
            keybindsProp = serializedObject.FindProperty("keybinds");
        }

        public override void OnInspectorGUI()
        {
            KeybindSettings keybindSettings = (KeybindSettings)target;
            serializedObject.Update();

            EditorGUILayout.PropertyField(inputModeProp);

            EditorGUILayout.Space();

            EditorGUI.indentLevel++;

            // Show keybinds based on the selected input mode
            foreach (var keybind in keybindSettings.keybinds)
            {
                if ((keybindSettings.inputMode == InputMode.KeyboardMouse && IsKeyboardMouseAction(keybind.actionName)) ||
                    (keybindSettings.inputMode == InputMode.Controller && IsControllerAction(keybind.actionName)))
                {
                    keybind.actionName = EditorGUILayout.TextField("Action Name", keybind.actionName);
                    keybind.keyCode = (KeyCode)EditorGUILayout.EnumPopup("Key Code", keybind.keyCode);
                    EditorGUILayout.Space();
                }
            }

            EditorGUI.indentLevel--;

            if (GUILayout.Button("Add Keybind"))
            {
                keybindSettings.keybinds.Add(new KeybindData());
            }

            if (GUILayout.Button("Remove Last Keybind"))
            {
                keybindSettings.keybinds.RemoveAt(keybindSettings.keybinds.Count - 1);
            }

            serializedObject.ApplyModifiedProperties();
        }

        private bool IsKeyboardMouseAction(string actionName)
        {
            // Implement your logic to check if the action is for keyboard/mouse
            return true; // Replace with actual logic
        }

        private bool IsControllerAction(string actionName)
        {
            // Implement your logic to check if the action is for controller
            return false; // Replace with actual logic
        }
    }
}


/*using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.MySettings
{
    [CustomEditor(typeof(KeybindSettings))]
    public class KeybindSettingsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            KeybindSettings keybindSettings = (KeybindSettings)target;
            serializedObject.Update();

            keybindSettings.inputMode = (InputMode)EditorGUILayout.EnumPopup("Input Mode", keybindSettings.inputMode);

            foreach (var keybind in keybindSettings.keybinds)
            {
                keybind.actionName = EditorGUILayout.TextField("Action Name", keybind.actionName);
                keybind.keyCode = (KeyCode)EditorGUILayout.EnumPopup("Key Code", keybind.keyCode);
                EditorGUILayout.Space();
            }

            if (GUILayout.Button("Add Keybind"))
            {
                keybindSettings.keybinds.Add(new KeybindData());
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}*/


/*using Assets.Scripts.MySettings;
using UnityEditor;


[CustomEditor(typeof(KeybindSettings))]
public class KeybindSettingsEditor : Editor
{
    #region Serialized Properties

    private SerializedProperty inputMode;

    // movement
    private SerializedProperty jumpKey;
    private SerializedProperty sprintKey;
    private SerializedProperty crouchKey;
    
    private SerializedProperty forwardKey;
    private SerializedProperty backwardKey;
    private SerializedProperty leftKey;
    private SerializedProperty rightKey;

    private SerializedProperty interactKey;
    
    private SerializedProperty inventoryKey;
    private SerializedProperty mapKey;

    private SerializedProperty pauseKey;
    
    private SerializedProperty attackKey;

    bool movmentGroup = false;
    # endregion 

    private void OnEnable()
    {
        inputMode = serializedObject.FindProperty("inputMode");

        jumpKey = serializedObject.FindProperty("jumpKey");
        sprintKey = serializedObject.FindProperty("sprintKey");
        crouchKey = serializedObject.FindProperty("crouchKey");

        forwardKey = serializedObject.FindProperty("forwardKey");
        backwardKey = serializedObject.FindProperty("backwardKey");
        leftKey = serializedObject.FindProperty("leftKey");
        rightKey = serializedObject.FindProperty("rightKey");

        interactKey = serializedObject.FindProperty("interactKey");

        inventoryKey = serializedObject.FindProperty("inventoryKey");
        mapKey = serializedObject.FindProperty("mapKey");

        pauseKey = serializedObject.FindProperty("pauseKey");

        attackKey = serializedObject.FindProperty("attackKey");

    }

    public override void OnInspectorGUI()
    {
        KeybindSettings keybindSettings = (KeybindSettings)target;

        serializedObject.Update();

        EditorGUILayout.PropertyField(inputMode);

        EditorGUILayout.Space();

        

        EditorGUILayout.LabelField("Keybinds");

        EditorGUI.indentLevel++;

        // check if the keybinds have been initialized

        //EditorGUILayout.PropertyField(inputMode);
        InputMode mode = keybindSettings.InputMode;

        EditorGUILayout.PropertyField(serializedObject.FindProperty(keybindSettings.GetKeyCodePropertyName(mode, "jumpKey")));
        EditorGUILayout.PropertyField(serializedObject.FindProperty(keybindSettings.GetKeyCodePropertyName(mode, "sprintKey")));
        // Add more keybind fields here

        EditorGUI.indentLevel--;

        serializedObject.ApplyModifiedProperties();
    }

*//*    private string GetKeyCodePropertyName(KeybindSettings.InputMode mode, string keyName)
    {
        return mode.ToString() + "_" + keyName;
    }*//*
}

*/